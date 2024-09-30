using Microsoft.AspNetCore.Mvc;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.DataAccess;
using SmartHRM.Models;
using SmartHRMWeb.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHRM.Models.ViewModels;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.RoleSuperAdmin)]
    public class AbsentTransactionController : Controller
	{
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod = new CurrentPeriod();
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AbsentTransactionController(IUnitOfWork unitOfWork, ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _db = db;

            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
		{
            IEnumerable<AbsentTransaction> objAbsentTransactionList = _unitOfWork.AbsentTransaction.GetAll(
                                                                        u => u.Period == currentPeriod.CurrentMonth && u.Pyear ==currentPeriod.Year,
                                                                        includeProperties: "Employee");

            return View(objAbsentTransactionList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {

            AbsentTransactionVM absentTransactionVM = new()
            {
                AbsentTransaction = new(),
                EmployeeList = _unitOfWork.Employee.GetAll(x => x.Terminated == false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
            };

            if (id == null || id == 0)
            {
                return View(absentTransactionVM);
            }
            else
            {
                absentTransactionVM.AbsentTransaction = _unitOfWork.AbsentTransaction.GetFirstOrDefault(u => u.Id == id);
                return View(absentTransactionVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(AbsentTransactionVM obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            double multyp = 0;

            if (ModelState.IsValid)
            {
                obj.AbsentTransaction.Period = currentPeriod.CurrentMonth;
                obj.AbsentTransaction.Pyear = currentPeriod.Year;               
                obj.AbsentTransaction.TransDate = DateTime.Today;
               

                obj.AbsentTransaction.Amount = Math.Round((getamountcasual(obj.AbsentTransaction.EmployeeId, obj.AbsentTransaction.DaysValue)), 2);

                if (obj.AbsentTransaction.Id == 0)
                {
                    obj.AbsentTransaction.CreatedBy = userId;
                    _unitOfWork.AbsentTransaction.Add(obj.AbsentTransaction);
                    TempData["success"] = "Absent Days Created Successfully";
                }
                else
                {
                    obj.AbsentTransaction.ModifiedBy = userId;
                    _unitOfWork.AbsentTransaction.Update(obj.AbsentTransaction);
                    TempData["success"] = "Absent Days Updated Successfully";
                }

                _unitOfWork.Save();

                //TempData["success"] = "Product Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        public decimal getamountcasual(int EmpID, decimal DaysValue)
        {
            var query =
                        from emp in _db.Employees
                        join grade in _db.EmployeeGrades on emp.EmployeeGradeId equals grade.Id 
                        where emp.Id == EmpID
                        select new
                        {
                            Id = emp.Id,
                            BasicPay = emp.BasicPay,
                            DailyRate = grade.DailyRate,
                            HourlyRate = grade.HourlyRate,
                            opthourly = grade.opthourly,
                            optdaily = grade.optdaily,
                            opttonnage = grade.opttonnage,
                            TonnageRate = grade.opttonnage,
                            permanentemp = grade.permanentemp,
                            fullName = emp.FullName
                        };
            if(query.Count() > 0 )
            {
                foreach( var item in query)
                {
                    if(item.permanentemp==true)
                    {
                        if(item.BasicPay > 0)
                        {
                            decimal empdays = decimal.Parse(generalParameter.workingdays.ToString());
                            decimal BasicSalary = decimal.Parse(item.BasicPay.ToString());
                            decimal result = ((BasicSalary / empdays) * DaysValue);
                            return result;
                        }
                        else
                        {
                            TempData["error"] = "This employee has no basic pay";
                            return 0;
                        }
                    }
                }
            }

            return 0;

        }


        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var absentTransList = _unitOfWork.AbsentTransaction.GetAll(u => u.Period == currentPeriod.CurrentMonth && u.Pyear==currentPeriod.Year, includeProperties: "Employee");

           // var absentTransList = _unitOfWork.AbsentTransaction.GetAll(includeProperties: "Employee");
            return Json(new { data = absentTransList });

        }



       

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.AbsentTransaction.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.AbsentTransaction.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion


    }
}
