using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using MailKit.Search;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class LoanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoanController(IUnitOfWork unitOfWork, ApplicationDbContext db,IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _db = db; 
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<Loan> objLoanList = _unitOfWork.Loan.GetAll(x=>x.Cleared==false);

            return View(objLoanList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            LoanVM loanVM = new()
            {
                Loan = new(),
                EmployeesList = _unitOfWork.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
                PayrollCodeList = _unitOfWork.PayrollCode.GetAll(x=>x.Loan==true).Select(u => new SelectListItem
                {
                    Text = u.PayName,
                    Value = u.Id.ToString()
                }),
            };

            if (id == null || id == 0)
            {
                return View(loanVM);
            }
            else
            {
                loanVM.Loan = _unitOfWork.Loan.GetFirstOrDefault(u => u.Id == id);
                loanVM.LoanPayable = loanVM.Loan.LoanAmount;               
                return View(loanVM);
            }
        }

        //Get
        
        public IActionResult Schedule(int? id)
        {
            LoanVM loanVM = new()
            {
				Loan = _unitOfWork.Loan.GetFirstOrDefault(u => u.Id == id, includeProperties: "Employee,PayrollCode"),
                LoanSchedules = _unitOfWork.LoanSchedule.GetAll(x => x.LoanId==id)
			};
			
			return View(loanVM);
			
           
        }

        //Post
        //Loan Schedule
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Schedule(LoanVM loanVM)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "";
            var currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);

            ScheduleLoan(loanVM.Loan.LoanAmount,
			   loanVM.Loan.InterestRate,
			   loanVM.Loan.NumberOfPeriods,
			   loanVM.Loan.LoanStartPeriod,
               currentPeriod.Year,
			   loanVM.Loan.Fixed,
			   loanVM.Loan.Id,
               userId);
            int loanid= loanVM.Loan.Id;
			return RedirectToAction("Schedule", new { id = loanid });

		}
        
        //End Loan Schedule


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(LoanVM obj)
        {
            int NoOfTimes = 0;
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
				if (obj.Loan.UseMonthlyRecov == false)
				{
					DateTime StartdateTime = DateTime.Parse(obj.Loan.LoanStartPeriod.ToString());
					DateTime EndateTime = DateTime.Parse(obj.Loan.LoanEndPeriod.ToString());
					NoOfTimes = GetMonthsBetween(StartdateTime, EndateTime);

				}
				else
				{
					NoOfTimes = int.Parse((obj.Loan.LoanAmount / obj.Loan.MonthlyRecoveryAmnt).ToString());

				}

				obj.Loan.CurrencyName = "KES";
				obj.Loan.NumberOfPeriods = NoOfTimes;

				if (obj.Loan.Id == 0)
                {
                    obj.Loan.CreatedBy = userId;
					_unitOfWork.Loan.Add(obj.Loan);
                }
                else
                {
                    obj.Loan.ModifiedBy = userId;
                    _db.Entry(obj.Loan).State = EntityState.Modified;
                    _unitOfWork.Loan.Update(obj.Loan);
                }
               
               
                _unitOfWork.Save();

               

                if (obj.Loan.Id == 0)
                {
                    TempData["success"] = "Product Created Successfully";
                }
                else
                {
                    TempData["success"] = "Product Updated Successfully";
                }
                //TempData["success"] = "Product Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

		public static int GetMonthsBetween(DateTime from, DateTime to)
		{
			if (from > to) return GetMonthsBetween(to, from);

			var monthDiff = Math.Abs((to.Year * 12 + (to.Month - 1)) - (from.Year * 12 + (from.Month - 1)));

			if (from.AddMonths(monthDiff) > to || to.Day < from.Day)
			{
				return monthDiff - 1;
			}
			else
			{
				return monthDiff;
			}
		}

		public void ScheduleLoan(decimal LoanPayable, decimal InterestRate, int NumberOfPeriods, string LoanStartPeriod, int StartYear, bool Fixed, int LoanId,string UserId)
        {
			
			_db.Database.ExecuteSql($" spScheduleLoan @bal={LoanPayable},@irate={InterestRate},@dur={NumberOfPeriods},@startPeriod={LoanStartPeriod},@startyear={StartYear},@fixed={Fixed},@LoanID={LoanId},@UserId={UserId}");

        }



        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll()
        {            
            var loanList = _unitOfWork.Loan.GetAll(x => x.Cleared==false, includeProperties: "Employee,PayrollCode");
            return Json(new { data = loanList });
        }

  
        [HttpGet]
        public IActionResult Loanschedule(int? LoanId)
        {
            var schedulelist = _unitOfWork.LoanSchedule.GetAll(x => x.LoanId == LoanId);
            return Json(new { data = schedulelist });
        }


        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var obj = _unitOfWork.Loan.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }           
            _unitOfWork.Loan.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
