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
	public class CompanyBranchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CompanyBranchController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<CompanyBranch> objCompanybranchList = _unitOfWork.CompanyBranch.GetAll();

            return View(objCompanybranchList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            CompanyBranchVM companyBranchVM = new()
            {
                CompanyBranch = new(),
                CompanyList = _unitOfWork.Company.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
               
            };

            if (id == null || id == 0)
            {
                return View(companyBranchVM);
            }
            else
            {
                companyBranchVM.CompanyBranch = _unitOfWork.CompanyBranch.GetFirstOrDefault(u => u.Id == id);
                return View(companyBranchVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CompanyBranchVM obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                
                if (obj.CompanyBranch.Id == 0)
                {
                    obj.CompanyBranch.CreatedBy= userId;
                    _unitOfWork.CompanyBranch.Add(obj.CompanyBranch);
					TempData["success"] = "Branch Created Successfully";
				}
                else
                {
                    obj.CompanyBranch.ModifiedBy = userId;
                    _unitOfWork.CompanyBranch.Update(obj.CompanyBranch);
					TempData["success"] = "Branch Updated Successfully";
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
            var compBranchList = _unitOfWork.CompanyBranch.GetAll(includeProperties: "Company");
            return Json(new { data = compBranchList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.CompanyBranch.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
                      

            _unitOfWork.CompanyBranch.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion
    }
}
