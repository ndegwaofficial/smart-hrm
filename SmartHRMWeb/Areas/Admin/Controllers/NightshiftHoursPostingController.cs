using Microsoft.AspNetCore.Mvc;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.DataAccess;
using SmartHRM.Models;
using SmartHRM.DataAccess.Repository;
using Microsoft.AspNetCore.Authorization;
using SmartHRMWeb.Helpers;
using SmartHRM.Models.ViewModels;
using System.Globalization;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.RoleSuperAdmin)]
    public class NightshiftHoursPostingController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod = new CurrentPeriod();

        public NightshiftHoursPostingController(IUnitOfWork unitOfWork, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;

            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<NightshiftHoursPosting> objNightShiftHoursList = _unitOfWork.NightShiftHoursPosting.GetAll(p => p.Picked == false,includeProperties: "Employee");
            return View(objNightShiftHoursList);
        }


        //Post
        [HttpPost]
        public async Task<IActionResult> PostNightShift([FromBody]List<NightShiftPostVM> nightshiftdata)
        {
            string result = string.Empty;
            int countRec = 0;
            try
            {
                foreach (var t in nightshiftdata)
                {
                    countRec++;
                    double amountx = 0;
                    amountx = GetNightShiftAmount(t.HoursWorked);
                    var checkifpostedbefore = (
                    from ats in _db.TransferredNightshiftHours
                    where ats.EmployeeId == t.EmpId && ats.Cmonth == currentPeriod.CurrentMonth && ats.Cyear == currentPeriod.Year && ats.HoursWorked == (decimal)t.HoursWorked
                    select new { ats }
                                                      ).ToList();
                    if (checkifpostedbefore.Count > 0)
                    {
                        TempData["error"] = "This person " + t.EmpId + " has similar record existing for this period";
                    }
                    else
                    {                      

                        OtherPayment opaymentmodel = new()
                        {
                            EmployeeId = t.EmpId,
                            TransPeriod = currentPeriod.CurrentMonth,
                            TransYear = currentPeriod.Year,
                            PayrollCodeId = 69,
                            PaymentName = "Night Shift Allowance".ToUpper(),
                            PaymentAmount = (decimal)amountx,
                            Taxable = true,
                            Reference = "Reference",
                            BalancePay = 0,
                            Stage = currentPeriod.Stage,
                            DateFrom =DateTime.Parse("2023-10-01"),
                            DateTo = DateTime.Parse("2023-10-15"),
                        };
                        _db.Add(opaymentmodel);
                        _db.SaveChanges();

                        TransferredNightshiftHours absmodel = new()
                        {
                            EmployeeId = t.EmpId,
                            Cmonth = currentPeriod.CurrentMonth,
                            Cyear = currentPeriod.Year,
                            HoursWorked = (decimal)t.HoursWorked,
                            Amount = (decimal)amountx,
                            TransDate = t.DatePosted,
                            Description = currentPeriod.CurrentMonth.ToString() + ' ' + currentPeriod.Year.ToString(),
                        };
                        _db.Add(absmodel);
                        _db.SaveChanges();

                    }
                    //Update Raw NightShift data that has been posted
                    NightshiftHoursPosting rawmodel = _unitOfWork.NightShiftHoursPosting.GetFirstOrDefault(u => u.Id == t.Id);
                    if (rawmodel != null)
                    {
                        rawmodel.Picked = true;
                        _db.Update(rawmodel);
                        _db.SaveChanges();
                    }
                }
                string message = countRec > 1 ? "s were" : " was";
                TempData["success"] = countRec.ToString() + " Record"+ message + " successfully Posted";
               
            }
            catch (Exception)
            {
                throw;
            }

             return Json(new {success=true});
        }


        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var nightSiftHoursPostingList = _unitOfWork.NightShiftHoursPosting.GetAll(p => p.Picked == false,  includeProperties: "Employee");
            return Json(new { data = nightSiftHoursPostingList });

        }

        [HttpGet]
        public IActionResult GetAllByDate(DateTime fromdate, DateTime toDate)
        {
            
            DateTime FromDate = Convert.ToDateTime(fromdate.ToString("yyyy-MM-dd"));
            DateTime ToDate = Convert.ToDateTime(toDate.ToString("yyyy-MM-dd"));

            var nightSiftHoursPostingList = _unitOfWork.NightShiftHoursPosting.GetAll(p => p.Picked == false && p.DatePosted >= FromDate && p.DatePosted <= ToDate, includeProperties: "Employee");
            return Json(new { data = nightSiftHoursPostingList });

        }




        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.NightShiftHoursPosting.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.NightShiftHoursPosting.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }

        [HttpGet]
        public double GetNightShiftAmount(decimal HoursWorked)
        {

            var data = FunctionHelper.getnightshiftamount((double)HoursWorked, (double) generalParameter.nightShiftRate);
            return data;

        }
        #endregion
    }
}
