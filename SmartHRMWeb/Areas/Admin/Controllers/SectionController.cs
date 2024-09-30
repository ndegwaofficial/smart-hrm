using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using static System.Collections.Specialized.BitVector32;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class SectionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SectionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<CompSection> objCompSectionList = _unitOfWork.CompSection.GetAll();

            return View(objCompSectionList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
			SectionVM sectionVM = new()
			{
				CompSection = new(),
				DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
				{
					Text = u.DepartmentName,
					Value = u.Id.ToString()
				}),
				DivisionList = _unitOfWork.Division.GetAll().Select(u => new SelectListItem
				{
					Text = u.DivisionName,
					Value = u.Id.ToString()
				}),

			};

			if (id == null || id == 0)
			{
				return View(sectionVM);
			}
			else
			{
				sectionVM.CompSection = _unitOfWork.CompSection.GetFirstOrDefault(u => u.Id == id);
				return View(sectionVM);
			}

		}


		//Post
		[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(SectionVM obj)
        {


			if (ModelState.IsValid)
			{

				if (obj.CompSection.Id == 0)
				{
					_unitOfWork.CompSection.Add(obj.CompSection);
					TempData["success"] = "Section Created Successfully";
				}
				else
				{
					_unitOfWork.CompSection.Update(obj.CompSection);
					TempData["success"] = "Section Updated Successfully";
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
            var sectionList = _unitOfWork.CompSection.GetAll(includeProperties: "Department,Division");
            return Json(new { data = sectionList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.CompSection.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.CompSection.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
