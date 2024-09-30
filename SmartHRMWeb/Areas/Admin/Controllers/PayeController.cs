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
	public class PayeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Paye> objPayeList = _unitOfWork.Paye.GetAll();

            return View(objPayeList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Paye paye = new();

            if (id == null || id == 0)
            {
                return View(paye);
            }
            else
            {
                paye = _unitOfWork.Paye.GetFirstOrDefault(u => u.Id == id);
                return View(paye);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Paye obj)
        {


            if (ModelState.IsValid)
            {
                
              
                if (obj.Id == 0)
                {
                    _unitOfWork.Paye.Add(obj);
                    TempData["success"] = "P.A.Y.E Created Successfully";
                }
                else
                {
                    _unitOfWork.Paye.Update(obj);
                    TempData["success"] = "P.A.Y.E Updated Successfully";
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
            var payeList = _unitOfWork.Paye.GetAll();
            return Json(new { data = payeList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Paye.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.Paye.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
