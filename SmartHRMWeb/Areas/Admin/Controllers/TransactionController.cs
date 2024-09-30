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
    public class TransactionController : Controller
	{
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod = new CurrentPeriod();

        public TransactionController(IUnitOfWork unitOfWork, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;

            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);

        }

        public IActionResult Index()
		{
            IEnumerable<Transaction> transactionList = _unitOfWork.Transaction.GetAll(u => u.Period == currentPeriod.CurrentMonth && u.CurrentYear == currentPeriod.Year , includeProperties: "Employee,PayrollCode");

            return View(transactionList);
        }

		//GET
		public IActionResult View()
		{

                TransactionsROVM transactionROVM = new TransactionsROVM()
                {
                    EmployeeList = _unitOfWork.Employee.GetAll(c => c.Terminated==false).Select(u => new SelectListItem
				    {
					    Text = u.FullNameWithCode,
					    Value = u.Id.ToString()
				    }),
                    EmpolyeeId=0, 
			    };                
				
				return View(transactionROVM);	

		}

        public IActionResult StopTransaction()
        {
            TransactionsSTOP transactionStop = new TransactionsSTOP()
            {
                EmployeeList = _unitOfWork.Employee.GetAll(c => c.Terminated == false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
                EmpolyeeId = 0,

                
            };

            return View(transactionStop);
           
        }

        //Post
        [HttpPost]
        public async Task<IActionResult> StopTransaction([FromBody] int[] ids)
        {
            string result = string.Empty;
            try
            {
                if(ids.Count() > 0)
                {
                    foreach(int id in ids)
                    {
                        var data = _db.Transactions.Where(e=>e.Id == id).FirstOrDefault();
                        if(data != null)
                        {
                            data.Stopped = true;
                            _db.Update(data);
                        }
                    }
                   await  _db.SaveChangesAsync();
                   TempData["success"] = "Transactions Updated Successfully";
                   result = "success";
                }
            }
            catch(Exception)
            {
                throw;
            }
            return View(result);

        }

        //GET
        public IActionResult Upsert(int? id,TransactionsROVM? transVM)
        {

            TransactionVM transactionVM = new()
            {
                Transaction = new(),
                EmployeeList = _unitOfWork.Employee.GetAll(x => x.Terminated == false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
                PayeollCodeList = _unitOfWork.PayrollCode.GetAll().Select(u => new SelectListItem
                {
                    Text = u.PayName,
                    Value = u.Id.ToString()
                }),
            };
            transactionVM.Transaction.EffectiveFromPeriod = DateTime.Today;
            transactionVM.Transaction.TransDate = DateTime.Today;
			transactionVM.Transaction.CurrentMonth = currentPeriod.CurrentMonth;
			transactionVM.Transaction.CurrentYear = currentPeriod.Year;		
			transactionVM.Transaction.Period = currentPeriod.CurrentMonth;
			transactionVM.Transaction.TransYear = currentPeriod.Year;
			transactionVM.Transaction.stage = currentPeriod.Stage;
            if (transVM.SelectedId>0)
            {
				transactionVM.Transaction.EmployeeId = transVM.SelectedId;
			}
            	


			if (id == null || id == 0)
            {
                return View(transactionVM);
            }
            else
            {

                transactionVM.Transaction = _unitOfWork.Transaction.GetFirstOrDefault(u => u.Id == id);
                return View(transactionVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(TransactionVM obj)
        {
            double multyp = 0;

            if (ModelState.IsValid)
            {
               
				if (obj.Transaction.Id == 0)
                {         

                    _unitOfWork.Transaction.Add(obj.Transaction);
                    TempData["success"] = "Transaction Created Successfully";
                }
                else
                {
                    _unitOfWork.Transaction.Update(obj.Transaction);
                    TempData["success"] = "Transaction Updated Successfully";
                }

                _unitOfWork.Save();

               
                return RedirectToAction("View");
            }
            return View(obj);

        }

     

        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll(int empid)
        {
            var transactionList = _unitOfWork.Transaction.GetAll(u => u.CurrentMonth == currentPeriod.CurrentMonth && u.CurrentYear == currentPeriod.Year && u.EmployeeId == empid &&  u.TransAmount > 0, includeProperties: "Employee,PayrollCode");

            return Json(new { data = transactionList });
        }

		
		[HttpGet]
		public IActionResult CurrentTransactions(int? EmpId)
		{
			var currentTransactionList = _unitOfWork.Transaction.GetAll(u => u.Period == currentPeriod.CurrentMonth && u.CurrentYear == currentPeriod.Year && u.EmployeeId== EmpId, includeProperties: "Employee,PayrollCode").OrderBy(c => c.PayrollCode.paycodeType);
            var sumtotal = _unitOfWork.Transaction.GetAll(u => u.Period == currentPeriod.CurrentMonth && u.CurrentYear == currentPeriod.Year  && u.EmployeeId == EmpId, includeProperties: "Employee,PayrollCode").Sum(c => c.TransAmount);
			return Json(new { data = currentTransactionList, totalamount= sumtotal.ToString("c") });
		}

        [HttpGet]
		public IActionResult FilteredTransactions(int? EmpId)
		{
			var currentTransactionList = _unitOfWork.Transaction.GetAll(u => u.Period == currentPeriod.CurrentMonth && u.CurrentYear == currentPeriod.Year && u.Stopped == false  && u.EmployeeId== EmpId, includeProperties: "Employee,PayrollCode").OrderBy(c => c.PayrollCode.paycodeType);
            var sumtotal = _unitOfWork.Transaction.GetAll(u => u.Period == currentPeriod.CurrentMonth && u.CurrentYear == currentPeriod.Year  && u.Stopped == false && u.EmployeeId == EmpId, includeProperties: "Employee,PayrollCode").Sum(c => c.TransAmount);
			return Json(new { data = currentTransactionList, totalamount= sumtotal.ToString("c") });
		}



		//Post
		[HttpDelete]
        public IActionResult Delete(int? id)
        {
            var obj = _unitOfWork.AbsentTransaction.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.AbsentTransaction.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion


    }
}
