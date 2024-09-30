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
	public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DepartmentController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {           

            IEnumerable<Department> objDepartmentList = _unitOfWork.Department.GetAll();

            return View(objDepartmentList);
        }

        //GET
        public IActionResult Upsert(int? id,bool active)
        {
			DepartmentVM departmentVM = new()
			{
				Department = new(),
				CompanyBranchList = _unitOfWork.CompanyBranch.GetAll().Select(u => new SelectListItem
				{
					Text = u.CompanyBranchName,
					Value = u.Id.ToString()
				}),
				DivisionList = _unitOfWork.Division.GetAll().Select(u => new SelectListItem
				{
					Text = u.DivisionName,
					Value = u.Id.ToString()
				}),

			};

			if (id == null || id == 0)
			{
				return View(departmentVM);
			}
			else
			{
				departmentVM.Department= _unitOfWork.Department.GetFirstOrDefault(u => u.Id == id);
				return View(departmentVM);
			}

		}


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(DepartmentVM obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
			{

				if (obj.Department.Id == 0)
				{
                    obj.Department.CreatedBy = userId;
					_unitOfWork.Department.Add(obj.Department);
					TempData["success"] = "Division Created Successfully";
				}
				else
				{
                    obj.Department.ModifiedBy = userId;
                    _unitOfWork.Department.Update(obj.Department);
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
            
            var departmentList = _unitOfWork.Department.GetAll(includeProperties: "CompanyBranch,Division");
            return Json(new { data = departmentList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Department.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.Department.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
