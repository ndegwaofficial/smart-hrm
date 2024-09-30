using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models.ViewModels;
using SmartHRM.Models;
using SmartHRM.DataAccess;
using Org.BouncyCastle.Bcpg;
using SmartHRMWeb.Helpers;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.RoleSuperAdmin)]
    public class TonnagePostingController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod = new CurrentPeriod();
        public TonnagePostingController(IUnitOfWork unitOfWork, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;

            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);
            _db = db;
        }

        public IActionResult Tonnage()
        {
            TonnageImportVM tonnageImportVM = new(); 
            tonnageImportVM.FromDate = DateTime.Now;
            tonnageImportVM.ToDate = DateTime.Now;

            return View(tonnageImportVM);
        }
        [HttpPost]
        public IActionResult Tonnage(TonnageImportVM obj)
        {
            TonnageImportVM tonnageImportVM = new();
            tonnageImportVM.FromDate = obj.FromDate;
            tonnageImportVM.ToDate = obj.ToDate;
            var objTonnageRetrieved = (
               from tnp in _db.TonnagePosts
               where tnp.Picked == false && tnp.PostDate <= obj.ToDate && tnp.PostDate >= obj.FromDate
               select new { tnp }
                      ).ToList();

            return View(objTonnageRetrieved);
        }
        public IActionResult Index()
        {
            var objTonnagePostingList = (
               from tnp in _db.TonnagePosts             
            where tnp.Picked == false 
            select new { tnp}
                      ).ToList();

            return View(objTonnagePostingList);
        }

       
        public IActionResult Postdata([FromBody] List<TimeAttendanceRawVM> model)
        {
            try
            {
                foreach (var t in model)
                {

                    if (t.ContractTypeId == 1)
                    {
                        //Check if 1 Permanent, post absent days
                        double amountx = 0;
                        amountx = GetAmount(t.EmpId, t.AbsentDays);
                        var checkifpostedbefore = (
                        from ats in _db.AbsentTransactions
                        where ats.EmployeeId == t.EmpId && ats.Period == currentPeriod.CurrentMonth && ats.Pyear == currentPeriod.Year && ats.DaysValue == (decimal)t.AbsentDays
                        select new { ats }
                                                          ).ToList();
                        if (checkifpostedbefore.Count > 0)
                        {
                            TempData["error"] = "This person " + t.EmpId + " has similar record existing for this period";

                        }
                        else
                        {
                            AbsentTransaction absmodel = new()
                            {
                                EmployeeId = t.EmpId,
                                Period = t.Period,
                                Pyear = t.Cyear,
                                DaysValue = (decimal)t.AbsentDays,
                                Amount = (decimal)amountx,
                                TransDate = DateTime.Now
                            };
                            _db.Add(absmodel);
                            _db.SaveChanges();

                        }


                    }
                    else if (t.ContractTypeId == 2)
                    {
                        //Check if 2 Casual, post Present Days
                        double amountcasual = 0;
                        amountcasual = GetAmountCasual(t.EmpId, t.PresentDays, 1);
                        var checkifHourspostedbefore = (
                                                  from emph in _db.EmployeesHoursDays
                        where emph.EmployeeId == t.EmpId && emph.Cmonth == t.Period && emph.Cyear == currentPeriod.Year && emph.Hoursdays == (decimal)t.PresentDays && emph.Stage == currentPeriod.Stage
                        select new { emph }
                                                         ).ToList();
                        if (checkifHourspostedbefore.Count > 0)
                        {
                            TempData["error"] = "This person " + t.EmpId + " has similar record existing for this period";
                        }
                        else
                        {
                            EmployeesHoursDay empmodel = new()
                            {
                                EmployeeId = t.EmpId,
                                Cmonth = t.Period,
                                Cyear = t.Cyear,
                                Hoursdays = (decimal)t.PresentDays,
                                Amount = (decimal)amountcasual,
                                Transdate = DateTime.Now,
                                Stage = currentPeriod.Stage,
                            };

                            _db.Add(empmodel);
                            _db.SaveChanges();

                        }

                    }
                    //Update Raw attendance data that has been posted
                    TimeAttendanceRaw rawmodel = _unitOfWork.TimeAttendanceRaw.GetFirstOrDefault(u => u.Id == t.Id);
                    if (rawmodel != null)
                    {
                        rawmodel.Posted = true;
                        _db.Update(rawmodel);
                        _db.SaveChanges();
                    }

                }

                //_db.SaveChanges();
                TempData["success"] = "Data Posted Successfully";
            }
            catch (Exception ex)
            {
                throw;
            }

            return Ok(model);

        }

        [HttpGet]
        public double GetAmountCasual(int empid, double dblvalue, double dblmultiplier)
        {

            var data = FunctionHelper.gethoursdaysamount(empid, dblvalue, dblmultiplier, _db);
            return data;

        }
        [HttpGet]
        public double GetAmount(int empid, double dblvalue)
        {

            var data = FunctionHelper.getamountcasual(empid, dblvalue, generalParameter.workingdays, _db);
            return data;

        }
    }
}
