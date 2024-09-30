using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using SmartHRMWeb.UserService;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class CurrencyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrencyController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;

        }

        public IActionResult Index()
        {
            IEnumerable<Currency> objCurrencyList = _unitOfWork.Currency.GetAll();

            return View(objCurrencyList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Currency currency = new();

            if (id == null || id == 0)
            {
                return View(currency);
            }
            else
            {
                currency = _unitOfWork.Currency.GetFirstOrDefault(u => u.Id == id);
                return View(currency);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Currency obj)
        {
            var userId= _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            

            if (ModelState.IsValid)
            {                              
                if (obj.Id == 0)
                {    
                    obj.CreatedBy = userId;
                    _unitOfWork.Currency.Add(obj);
                    TempData["success"] = "Currency Created Successfully";
                }
                else
                {
                    obj.ModifiedBy = userId;
                    _unitOfWork.Currency.Update(obj);
                    TempData["success"] = "Currency Updated Successfully";
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
            var currencyList = _unitOfWork.Currency.GetAll();
            return Json(new { data = currencyList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Currency.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.Currency.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
