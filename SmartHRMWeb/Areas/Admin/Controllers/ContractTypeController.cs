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
	public class ContractTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ContractTypeController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<ContractType> objContractTypeList = _unitOfWork.ContractType.GetAll();

            return View(objContractTypeList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            ContractType contractType = new();

            if (id == null || id == 0)
            {
                return View(contractType);
            }
            else
            {
				contractType = _unitOfWork.ContractType.GetFirstOrDefault(u => u.Id == id);
                return View(contractType);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ContractType obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                
              
                if (obj.Id == 0)
                {
                    obj.CreatedBy = userId;
                    _unitOfWork.ContractType.Add(obj);
                    TempData["success"] = "Contract Type Created Successfully";
                }
                else
                {
                    obj.ModifiedBy = userId;
                    _unitOfWork.ContractType.Update(obj);
                    TempData["success"] = "Contract Type Updated Successfully";
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
            var contractTypeList = _unitOfWork.ContractType.GetAll();
            return Json(new { data = contractTypeList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.ContractType.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.ContractType.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
