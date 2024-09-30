using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class NhifController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public NhifController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Nhif> objNhifList = _unitOfWork.Nhif.GetAll();

            return View(objNhifList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Nhif nhif = new();

            if (id == null || id == 0)
            {
                return View(nhif);
            }
            else
            {
                nhif = _unitOfWork.Nhif.GetFirstOrDefault(u => u.Id == id);
                return View(nhif);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Nhif obj)
        {

            if (ModelState.IsValid)
            {                
              
                if (obj.Id == 0)
                {
                    _unitOfWork.Nhif.Add(obj);
                    TempData["success"] = "N.H.I.F Created Successfully";
                }
                else
                {
                    _unitOfWork.Nhif.Update(obj);
                    TempData["success"] = "N.H.I.F Updated Successfully";
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
            var nhifList = _unitOfWork.Nhif.GetAll();
            return Json(new { data = nhifList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Nhif.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.Nhif.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
