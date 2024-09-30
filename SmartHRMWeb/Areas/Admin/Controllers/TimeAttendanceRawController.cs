using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using SmartHRMWeb.Helpers;
using Stripe;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class TimeAttendanceRawController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod =new CurrentPeriod();
        public TimeAttendanceRawController(IUnitOfWork unitOfWork, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;

            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);
            _db = db;
        }

        public IActionResult Index()
        {
            
            IEnumerable<TimeAttendanceRaw> objtimeAttendanceRawList = _unitOfWork.TimeAttendanceRaw.GetAll(p => p.Posted == false, includeProperties: "Employee");
            return View(objtimeAttendanceRawList);

        }

       
        public async Task<IActionResult> PostTimeAttendance([FromBody] List<TimeAttendanceRawVM> timeattendanceData)
        {
            int countRec = 0;
            try
            {
                foreach(var t in timeattendanceData)
                {
                    countRec++;
                    if (t.ContractTypeId == 1 && t.AbsentDays>0)
                    {
                        //Check if 1 Permanent, post absent days
                        double amountx =0;
                        amountx = GetAmount(t.EmpId, t.AbsentDays);
                        var checkifpostedbefore = (
                                                   from ats in _db.AbsentTransactions                                                  
                                                   where ats.EmployeeId == t.EmpId && ats.Period == currentPeriod.CurrentMonth && ats.Pyear == currentPeriod.Year && ats.DaysValue == (decimal) t.AbsentDays
                                                   select new { ats }
                                                          ).ToList();
                        if(checkifpostedbefore.Count>0)
                        {
                            TempData["error"] = "This person "+ t.EmpId +" has similar record existing for this period";
                           
                        }
                        else 
                        {
                           
                            AbsentTransaction absmodel = new()
                            {
                                EmployeeId = t.EmpId,
                                Period = t.Period,
                                Pyear = t.Cyear,
                                DaysValue= (decimal) t.AbsentDays,
                                Amount=(decimal) amountx,
                                TransDate = DateTime.Now
                            };
                            _db.Add(absmodel);
                            _db.SaveChanges();
                                                       
                        }


                    }
                    else if (t.ContractTypeId == 2 && t.PresentDays>0)
                    {
                        //Check if 2 Casual, post Present Days
                        double amountcasual =0;
                        amountcasual = GetAmountCasual(t.EmpId, t.PresentDays, 1);
                        var checkifHourspostedbefore = (
                                                  from emph in _db.EmployeesHoursDays
                                                  where emph.EmployeeId == t.EmpId && emph.Cmonth == t.Period && emph.Cyear == currentPeriod.Year && emph.Hoursdays == (decimal)t.PresentDays && emph.Stage == currentPeriod.Stage
                                                  select new { emph }
                                                         ).ToList();
                        if (checkifHourspostedbefore.Count>0)
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
                    TimeAttendanceRaw rawmodel  = _unitOfWork.TimeAttendanceRaw.GetFirstOrDefault(u=>u.Id == t.Id);
                    if (rawmodel != null)
                    {
                        rawmodel.Posted = true;
                        _db.Update(rawmodel);
                        _db.SaveChanges();
                    }

                }

                //_db.SaveChanges();
                string message = countRec > 1 ? "s were" : " was";
                TempData["success"] = countRec.ToString() + " Record" + message + " successfully Posted";
            }
            catch (Exception)
            {
                throw;
            }

            return Json(new { success = true });

        }

        //GET
        public IActionResult Upsert(int? id)
        {
            EmployeesHoursDayVM employeesHoursDayVM = new()
            {
                EmployeesHoursDay = new(),
                EmployeeList = _unitOfWork.Employee.GetAll(x => x.Terminated == false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
               

            };

            if (id == null || id == 0)
            {
                return View(employeesHoursDayVM);
            }
            else
            {
                employeesHoursDayVM.EmployeesHoursDay = _unitOfWork.EmployeesHoursDay.GetFirstOrDefault(u => u.Id == id);
                return View(employeesHoursDayVM);
            }

        }


        

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployeesHoursDayVM obj)
        {
            if (ModelState.IsValid)
            {
                obj.EmployeesHoursDay.Cmonth = currentPeriod.CurrentMonth;
                obj.EmployeesHoursDay.Cyear = currentPeriod.Year;
                obj.EmployeesHoursDay.Stage = currentPeriod.Stage;
                obj.EmployeesHoursDay.Transdate = DateTime.Today;

                if (obj.EmployeesHoursDay.Id == 0)
                {
                    _unitOfWork.EmployeesHoursDay.Add(obj.EmployeesHoursDay);
                    TempData["success"] = "Division Created Successfully";
                }
                else
                {
                    _unitOfWork.EmployeesHoursDay.Update(obj.EmployeesHoursDay);
                    TempData["success"] = "Division Updated Successfully";
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
            var timeAndAttendanceList = _unitOfWork.TimeAttendanceRaw.GetAll(p => p.Posted == false, includeProperties: "Employee");
            return Json(new { data = timeAndAttendanceList });

        }

        [AllowAnonymous]
        [HttpGet]
        public bool PostAttendance(List<TimeAttendanceRaw>model)
        {
            try
            {
                foreach(var item in model)
                {
                    TimeAttendanceRaw postdata = new TimeAttendanceRaw()
                    {
                        Period = currentPeriod.CurrentMonth,
                        Cyear = currentPeriod.Year,
                        EmployeeId = item.EmployeeId,
                        PresentDays = item.PresentDays,
                        AbsentDays = item.AbsentDays,
                        Posted = false

                    };

                    _db.Add(postdata);
                    _db.SaveChanges();
                }
                return true;
            }catch (Exception ex)
            {
                return false;
                throw;
            }
            
        }


        [HttpGet]
        public double GetAmountCasual(int empid, double dblvalue, double dblmultiplier)
        {

            var data = FunctionHelper.gethoursdaysamount(empid,dblvalue,dblmultiplier,_db);
            return data;

        }
        [HttpGet]
        public double GetAmount(int empid, double dblvalue)
        {

            var data = FunctionHelper.getamountcasual(empid, dblvalue, generalParameter.workingdays, _db);
            return data;

        }
        

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.TimeAttendanceRaw.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

           
            _unitOfWork.TimeAttendanceRaw.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion

    }
}
