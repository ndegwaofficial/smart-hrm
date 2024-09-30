using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Utility.Constants;
using System.Security.Claims;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.RoleSuperAdmin)]
    public class BankController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BankController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            IEnumerable<Bank> objBankList = _unitOfWork.Bank.GetAll();
            return View(objBankList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Bank bank = new();

            if (id == null || id == 0)
            {
                return View(bank);
            }
            else
            {
                bank = _unitOfWork.Bank.GetFirstOrDefault(u => u.Id == id);
                return View(bank);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Bank obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {


                if (obj.Id == 0)
                {
                    obj.CreatedBy = userId;
                    _unitOfWork.Bank.Add(obj);
                    TempData["success"] = "Bank Created Successfully";
                }
                else
                {
                    obj.ModifiedBy= userId;
                    _unitOfWork.Bank.Update(obj);
                    TempData["success"] = "Bank Updated Successfully";
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
            var bankList = _unitOfWork.Bank.GetAll();
            return Json(new { data = bankList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Bank.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }


            _unitOfWork.Bank.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
