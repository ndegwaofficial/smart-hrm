using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using SmartHRMWeb.Helpers;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class OvertimeAbsentTransactionController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod =new CurrentPeriod();
      
       
        public OvertimeAbsentTransactionController(IUnitOfWork unitOfWork, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;

            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);
          
        }

        [BindProperty]
        public OvertimeAbsentTransactionVM OvertimeAbsentTransactionVM { get; set; }
        public IActionResult Index()
        {
            IEnumerable<OvertimeAbsentTransaction> objOvertimeAbsentTransactionList = _unitOfWork.OvertimeAbsentTransaction.GetAll(includeProperties: "Employee");
            return View(objOvertimeAbsentTransactionList);
        }



        //GET
        public IActionResult Upsert(int? id)
        {
           
            OvertimeAbsentTransactionVM overtimeAbsentTransactionVM = new()
            {
                OvertimeAbsentTransaction = new(),
                EmployeeList = _unitOfWork.Employee.GetAll(x => x.Terminated == false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),             

            };

            if (id == null || id == 0)
            {
                return View(overtimeAbsentTransactionVM);
            }
            else
            {
                overtimeAbsentTransactionVM.OvertimeAbsentTransaction = _unitOfWork.OvertimeAbsentTransaction.GetFirstOrDefault(u => u.Id == id);
                return View(overtimeAbsentTransactionVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(OvertimeAbsentTransactionVM obj)
        {
            double multyp = 0;

            if (ModelState.IsValid)
            {
                obj.OvertimeAbsentTransaction.Period = currentPeriod.CurrentMonth;
                obj.OvertimeAbsentTransaction.Pyear = currentPeriod.Year;
                obj.OvertimeAbsentTransaction.stage = currentPeriod.Stage;
                obj.OvertimeAbsentTransaction.Transdate = DateTime.Today;

                if (obj.OvertimeAbsentTransaction.opt15 == true)
                {
                    multyp = 1.5;
                }
                else if(obj.OvertimeAbsentTransaction.opt2 == true)
                {
                    multyp = 2;
                }

               obj.OvertimeAbsentTransaction.Amount = Math.Round((GetAmount(obj.OvertimeAbsentTransaction.EmployeeId,obj.OvertimeAbsentTransaction.HoursValue, multyp)),2);

                if (obj.OvertimeAbsentTransaction.Id == 0)
                {
                    _unitOfWork.OvertimeAbsentTransaction.Add(obj.OvertimeAbsentTransaction);
                    TempData["success"] = "Overtime Created Successfully";
                }
                else
                {
                    _unitOfWork.OvertimeAbsentTransaction.Update(obj.OvertimeAbsentTransaction);
                    TempData["success"] = "Overtime Updated Successfully";
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

            var overtimeabsentTransList = _unitOfWork.OvertimeAbsentTransaction.GetAll(includeProperties: "Employee");
            return Json(new { data = overtimeabsentTransList });
           
        }


        
        [HttpGet]
        public  double  GetAmount(int empid,double dblvalue, double dblmultiplier)
        {

            var data = FunctionHelper.getamountcasualovertime(empid, dblvalue,generalParameter.workingdays,dblmultiplier,_db);
            return 1;

        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.OvertimeAbsentTransaction.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
                       
            _unitOfWork.OvertimeAbsentTransaction.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
