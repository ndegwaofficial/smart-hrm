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
	public class GradeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GradeController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<EmployeeGrade> objGradeList = _unitOfWork.EmployeeGrade.GetAll();

            return View(objGradeList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            EmployeeGrade employeeGrade = new();

            if (id == null || id == 0)
            {
                return View(employeeGrade);
            }
            else
            {
				employeeGrade = _unitOfWork.EmployeeGrade.GetFirstOrDefault(u => u.Id == id);
                return View(employeeGrade);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployeeGrade obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {                
              
                if (obj.Id == 0)
                {
                    obj.CreatedBy = userId;
                    _unitOfWork.EmployeeGrade.Add(obj);
                    TempData["success"] = "Grade Created Successfully";
                }
                else
                {
                    obj.ModifiedBy = userId;
                    _unitOfWork.EmployeeGrade.Update(obj);
                    TempData["success"] = "Grade Updated Successfully";
                }

                _unitOfWork.Save();
               
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var gradeList = _unitOfWork.EmployeeGrade.GetAll();
            return Json(new { data = gradeList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.EmployeeGrade.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.EmployeeGrade.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
