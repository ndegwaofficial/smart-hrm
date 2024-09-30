using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class EmployeesHoursDayController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod =new CurrentPeriod();
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EmployeesHoursDayController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            
            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x=>x.Id == 1);
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            
            IEnumerable<EmployeesHoursDay> objemployeeHoursDayList = _unitOfWork.EmployeesHoursDay.GetAll(includeProperties: "Employee");

            return View(objemployeeHoursDayList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            EmployeesHoursDayVM employeesHoursDayVM = new()
            {
                EmployeesHoursDay = new(),
                EmployeeList = _unitOfWork.Employee.GetAll(x => x.Terminated == false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
               

            };

            if (id == null || id == 0)
            {
                return View(employeesHoursDayVM);
            }
            else
            {
                employeesHoursDayVM.EmployeesHoursDay = _unitOfWork.EmployeesHoursDay.GetFirstOrDefault(u => u.Id == id);
                return View(employeesHoursDayVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployeesHoursDayVM obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                obj.EmployeesHoursDay.Cmonth = currentPeriod.CurrentMonth;
                obj.EmployeesHoursDay.Cyear = currentPeriod.Year;
                obj.EmployeesHoursDay.Stage = currentPeriod.Stage;
                obj.EmployeesHoursDay.Transdate = DateTime.Today;

                if (obj.EmployeesHoursDay.Id == 0)
                {
                    obj.EmployeesHoursDay.CreatedBy = userId;
                    _unitOfWork.EmployeesHoursDay.Add(obj.EmployeesHoursDay);
                    TempData["success"] = "Division Created Successfully";
                }
                else
                {
                    obj.EmployeesHoursDay.ModifiedBy = userId;
                    _unitOfWork.EmployeesHoursDay.Update(obj.EmployeesHoursDay);
                    TempData["success"] = "Division Updated Successfully";
                }

                _unitOfWork.Save();

                //TempData["success"] = "Product Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var employeeHoursDayList = _unitOfWork.EmployeesHoursDay.GetAll(includeProperties: "Employee");
            return Json(new { data = employeeHoursDayList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.EmployeesHoursDay.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.EmployeesHoursDay.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
