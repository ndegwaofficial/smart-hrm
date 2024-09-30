using Microsoft.AspNetCore.Mvc;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.DataAccess;
using SmartHRM.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartHRM.Models.ViewModels;
using System.Security.Claims;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CLoanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CLoanController(IUnitOfWork unitOfWork, ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _db = db;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            IEnumerable<CLoan> objCLoanList = _unitOfWork.CLoan.GetAll(x => x.Cleared == false);

            return View(objCLoanList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            CLoanVM CloanVM = new()
            {
                CLoan = new(),
                EmployeesList = _unitOfWork.Employee.GetAll(x=>x.ContractTypeId==2 && x.Terminated==false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
                PayrollCodeList = _unitOfWork.PayrollCode.GetAll(x => x.Loan == true).Select(u => new SelectListItem
                {
                    Text = u.PayName,
                    Value = u.Id.ToString()
                }),
            };

            if (id == null || id == 0)
            {
                return View(CloanVM);
            }
            else
            {
                CloanVM.CLoan = _unitOfWork.CLoan.GetFirstOrDefault(u => u.Id == id);
                CloanVM.LoanPayable = CloanVM.CLoan.LoanAmount;
                return View(CloanVM);
            }
        }

        //Get

        public IActionResult Schedule(int? id)
        {
            CLoanVM CloanVM = new()
            {
                CLoan = _unitOfWork.CLoan.GetFirstOrDefault(u => u.Id == id, includeProperties: "Employee,PayrollCode"),
                CLoanSchedules = _unitOfWork.CLoanSchedule.GetAll(x => x.CLoanId == id)
            };

            return View(CloanVM);


        }

        //Post
        //Loan Schedule
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Schedule(CLoanVM CloanVM)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)??"";
            var currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);

            ScheduleLoan(CloanVM.CLoan.LoanAmount,
               CloanVM.CLoan.InterestRate,
               CloanVM.CLoan.NumberOfPeriods,
               CloanVM.CLoan.LoanStartPeriod,
               currentPeriod.Year,
               CloanVM.CLoan.Fixed,
               CloanVM.CLoan.Id,
               currentPeriod.Stage,
               userId
               );
            int loanid = CloanVM.CLoan.Id;
            return RedirectToAction("Schedule", new { id = loanid });

        }

        //End Loan Schedule


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CLoanVM obj)
        {
            int NoOfTimes = 0;
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                if (obj.CLoan.UseStageRecov == false)
                {
                    DateTime StartdateTime = DateTime.Parse(obj.CLoan.LoanStartPeriod.ToString());
                    DateTime EndateTime = DateTime.Parse(obj.CLoan.LoanEndPeriod.ToString());
                    NoOfTimes = GetMonthsBetween(StartdateTime, EndateTime);

                }
                else
                {
                    NoOfTimes = int.Parse((obj.CLoan.LoanAmount / obj.CLoan.MonthlyRecoveryAmnt).ToString());

                }

                obj.CLoan.CurrencyName = "KES";
                obj.CLoan.NumberOfPeriods = NoOfTimes;

                if (obj.CLoan.Id == 0)
                {
                    obj.CLoan.CreatedBy = userId;
                    _unitOfWork.CLoan.Add(obj.CLoan);
                }
                else
                {
                    obj.CLoan.ModifiedBy = userId;
                    _db.Entry(obj.CLoan).State = EntityState.Modified;
                    _unitOfWork.CLoan.Update(obj.CLoan);
                }


                _unitOfWork.Save();



                if (obj.CLoan.Id == 0)
                {
                    TempData["success"] = "Product Created Successfully";
                }
                else
                {
                    TempData["success"] = "Product Updated Successfully";
                }
                //TempData["success"] = "Product Created Successfully";
                return RedirectToAction("Index","CLoan");
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

        public void ScheduleLoan(decimal LoanPayable, decimal InterestRate, int NumberOfPeriods, string LoanStartPeriod, int StartYear, bool Fixed, int LoanId,int startstage,string UserId)
        {

            _db.Database.ExecuteSql($" c_spScheduleLoan @bal={LoanPayable},@irate={InterestRate},@duration={NumberOfPeriods},@startPeriod={LoanStartPeriod},@startyear={StartYear},@fixed={Fixed},@LoanID={LoanId},@Startstage={startstage},@UserId={UserId}");

        }



        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var cloanList = _unitOfWork.CLoan.GetAll(x => x.Cleared == false, includeProperties: "Employee,PayrollCode");
            return Json(new { data = cloanList });
        }


        [HttpGet]
        public IActionResult Loanschedule(int? LoanId)
        {
            var schedulelist = _unitOfWork.CLoanSchedule.GetAll(x => x.CLoanId == LoanId);
            return Json(new { data = schedulelist });
        }


        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var obj = _unitOfWork.CLoan.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.CLoan.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
