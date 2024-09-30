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
	public class PayrollCodeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayrollCodeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<PayrollCode> objPayrollCodeList = _unitOfWork.PayrollCode.GetAll();

            return View(objPayrollCodeList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            PayrollCode payrollcode = new();

            if (id == null || id == 0)
            {
                return View(payrollcode);
            }
            else
            {
                payrollcode = _unitOfWork.PayrollCode.GetFirstOrDefault(u => u.Id == id);
                return View(payrollcode);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(PayrollCode obj)
        {


            if (ModelState.IsValid)
            {
                
              
                if (obj.Id == 0)
                {
                    _unitOfWork.PayrollCode.Add(obj);
                    TempData["success"] = "Payroll Code Created Successfully";
                }
                else
                {
                    _unitOfWork.PayrollCode.Update(obj);
                    TempData["success"] = "Payroll Code Updated Successfully";
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
            var payrollcodeList = _unitOfWork.PayrollCode.GetAll();
            return Json(new { data = payrollcodeList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.PayrollCode.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.PayrollCode.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
