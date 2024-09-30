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
	public class DivisionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DivisionController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<Division> objDivisionList = _unitOfWork.Division.GetAll(includeProperties: "CompanyBranch");

            return View(objDivisionList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            DivisionVM divisionVM = new()
            {
                Division = new(),
                CompanyBranchList = _unitOfWork.CompanyBranch.GetAll().Select(u => new SelectListItem
                {
                    Text = u.CompanyBranchName,
                    Value = u.Id.ToString()
                }),
               
            };

            if (id == null || id == 0)
            {
                return View(divisionVM);
            }
            else
            {
				divisionVM.Division = _unitOfWork.Division.GetFirstOrDefault(u => u.Id == id);
                return View(divisionVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(DivisionVM obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                
                if (obj.Division.Id == 0)
                {
                    obj.Division.CreatedBy = userId;
                    _unitOfWork.Division.Add(obj.Division);
					TempData["success"] = "Division Created Successfully";
				}
                else
                {
                    obj.Division.ModifiedBy = userId;
                    _unitOfWork.Division.Update(obj.Division);
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
            var divisionList = _unitOfWork.Division.GetAll(includeProperties: "CompanyBranch");
            return Json(new { data = divisionList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Division.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
                      

            _unitOfWork.Division.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion
    }
}
