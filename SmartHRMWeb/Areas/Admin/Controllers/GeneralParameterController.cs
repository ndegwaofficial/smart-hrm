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
    public class GeneralParameterController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GeneralParameterController(IUnitOfWork unitOfWork,IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;  
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            IEnumerable<GeneralParameter> objGenParamsList = _unitOfWork.GeneralParameter.GetAll();

            return View(objGenParamsList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            GeneralParameter genParams = new();

            if (id == null || id == 0)
            {
                return View(genParams);
            }
            else
            {
                genParams = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == id);
                return View(genParams);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(GeneralParameter obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {


                if (obj.Id == 0)
                {
                    
                    _unitOfWork.GeneralParameter.Add(obj);
                    TempData["success"] = "Parameter Created Successfully";
                }
                else
                {
                    _unitOfWork.GeneralParameter.Update(obj);
                    TempData["success"] = "Parameter Updated Successfully";
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
            var genparamsList = _unitOfWork.GeneralParameter.GetAll();
            return Json(new { data = genparamsList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }


            _unitOfWork.GeneralParameter.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
