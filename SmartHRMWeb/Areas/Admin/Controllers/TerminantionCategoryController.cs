using Microsoft.AspNetCore.Mvc;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.DataAccess;
using SmartHRM.Models;
using SmartHRMWeb.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHRM.Models.ViewModels;
using System.Drawing;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Identity;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.RoleSuperAdmin)]
    public class TerminantionCategoryController : Controller
	{
    
        private readonly IUnitOfWork _unitOfWork;


        public TerminantionCategoryController(IUnitOfWork unitOfWork, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<TerminationCategory> objTerminationCategoryList = _unitOfWork.TerminantionCategory.GetAll();

            return View(objTerminationCategoryList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            TerminationCategory terminationCategory = new();

            if (id == null || id == 0)
            {
                return View(terminationCategory);
            }
            else
            {
                terminationCategory = _unitOfWork.TerminantionCategory.GetFirstOrDefault(u => u.Id == id);
                return View(terminationCategory);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(TerminationCategory obj)
        {


            if (ModelState.IsValid)
            {


                if (obj.Id == 0)
                {
                    _unitOfWork.TerminantionCategory.Add(obj);
                    TempData["success"] = "Termination Category Created Successfully";
                }
                else
                {
                    _unitOfWork.TerminantionCategory.Update(obj);
                    TempData["success"] = "Terminantion Category Updated Successfully";
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
            var terminationcategoryList = _unitOfWork.TerminantionCategory.GetAll();
            return Json(new { data = terminationcategoryList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.TerminantionCategory.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }


            _unitOfWork.TerminantionCategory.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
