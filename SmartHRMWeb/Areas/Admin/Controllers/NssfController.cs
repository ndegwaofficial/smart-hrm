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
	public class NssfController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public NssfController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Nssf> objNssfList = _unitOfWork.Nssf.GetAll();

            return View(objNssfList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Nssf nssf = new();

            if (id == null || id == 0)
            {
                return View(nssf);
            }
            else
            {
                nssf = _unitOfWork.Nssf.GetFirstOrDefault(u => u.Id == id);
                return View(nssf);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Nssf obj)
        {


            if (ModelState.IsValid)
            {
                
              
                if (obj.Id == 0)
                {
                    _unitOfWork.Nssf.Add(obj);
                    TempData["success"] = "N.S.S.F Created Successfully";
                }
                else
                {
                    _unitOfWork.Nssf.Update(obj);
                    TempData["success"] = "N.S.S.F Updated Successfully";
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
            var nssfList = _unitOfWork.Nssf.GetAll();
            return Json(new { data = nssfList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Nssf.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.Nssf.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
