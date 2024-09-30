using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using SmartHRM.Utility.Constants;
using System.Security.Claims;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.RoleSuperAdmin)]
    public class BankBranchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BankBranchController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<BankBranch> objBankBranchList = _unitOfWork.BankBranch.GetAll(includeProperties: "Bank");
            return View(objBankBranchList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            BankbranchVM bankbranchVM = new()
            {
                BankBranch = new(),
                BankList = _unitOfWork.BankBranch.GetAll().Select(u => new SelectListItem
                {
                    Text = u.BankBranchName,
                    Value = u.Id.ToString()
                }),

            };

            if (id == null || id == 0)
            {
                return View(bankbranchVM);
            }
            else
            {
                bankbranchVM.BankBranch = _unitOfWork.BankBranch.GetFirstOrDefault(u => u.Id == id);
                return View(bankbranchVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(BankbranchVM obj)
        {

            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {

                if (obj.BankBranch.Id == 0)
                {
                    obj.BankBranch.CreatedBy = userId;
                    _unitOfWork.BankBranch.Add(obj.BankBranch);
                    TempData["success"] = "Bank Branch Created Successfully";
                }
                else
                {
                    obj.BankBranch.ModifiedBy = userId;
                    _unitOfWork.BankBranch.Update(obj.BankBranch);
                    TempData["success"] = "Bank Branch Updated Successfully";
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
            var bankbranchList = _unitOfWork.BankBranch.GetAll(includeProperties: "Bank");
            return Json(new { data = bankbranchList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.BankBranch.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }


            _unitOfWork.BankBranch.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
