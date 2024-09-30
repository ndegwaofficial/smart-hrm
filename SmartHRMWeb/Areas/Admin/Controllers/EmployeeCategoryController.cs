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
	public class EmployeeCategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EmployeeCategoryController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<EmployeeCategory> objEmpCategoryList = _unitOfWork.EmployeeCategory.GetAll();

            return View(objEmpCategoryList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            EmployeeCategory employeeCategory = new();

            if (id == null || id == 0)
            {
                return View(employeeCategory);
            }
            else
            {
                employeeCategory = _unitOfWork.EmployeeCategory.GetFirstOrDefault(u => u.Id == id);
                return View(employeeCategory);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployeeCategory obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {                
              
                if (obj.Id == 0)
                {
                    obj.CreatedBy = userId;
                    _unitOfWork.EmployeeCategory.Add(obj);
                    TempData["success"] = "Category Created Successfully";
                }
                else
                {
                    obj.ModifiedBy = userId;
                    _unitOfWork.EmployeeCategory.Update(obj);
                    TempData["success"] = "Category Updated Successfully";
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
            var empcategoryList = _unitOfWork.EmployeeCategory.GetAll();
            return Json(new { data = empcategoryList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.EmployeeCategory.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.EmployeeCategory.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
