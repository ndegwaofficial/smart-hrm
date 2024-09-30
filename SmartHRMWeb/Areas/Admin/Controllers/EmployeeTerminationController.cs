using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class EmployeeTerminationController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmployeeTerminationController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<EmployeeTermination> employeeTerminationList = _unitOfWork.EmployeeTermination.GetAll(u => u.Approved == false, includeProperties: "Employee,TerminationCategory");
            if (employeeTerminationList.Count() <= 0)
            {
                TempData["error"] = "No records to Display";
            }
            return View(employeeTerminationList);
        }
        public IActionResult ApproveTermination()
        {
            IEnumerable<EmployeeTermination> employeeTerminationList = _unitOfWork.EmployeeTermination.GetAll(u => u.Approved == false, includeProperties: "Employee,TerminationCategory");
            if (employeeTerminationList.Count() <= 0)
            {
                TempData["error"] = "No records to Display";
            }
            return View(employeeTerminationList);

        }

        //Post
        [HttpPost]
        public  async Task<IActionResult> ApproveTermination([FromBody] int[] ids)
        {
            string result = string.Empty;
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                if (ids.Count() > 0)
                {
                    foreach (int id in ids)
                    {
                        var data = _db.EmployeeTerminations.Where(e => e.Id == id).FirstOrDefault();
                        if (data != null)
                        {
                            data.ModifiedBy = userId;
                            data.Approved = true;
                            data.ApprovedById = userId;
                            data.ApprovalDate = DateTime.Now;
                            data.ApprovalStatus = "Approved";
                            _db.Update(data);
                        }

                        var updateEmpstatus = _db.Employees.Where(u=>u.Id==data.EmployeeId).FirstOrDefault();
                        if (updateEmpstatus != null) 
                        { 
                            updateEmpstatus.Terminated = true;
                            updateEmpstatus.ModifiedBy = userId;
                            _db.Update(updateEmpstatus);
                            TempData["success"] = "Termination Approval Successfully";
                            result = "success";
                        }
                    }
                     await _db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
               
            }
            catch (Exception)
            {
                throw;
            }
            return View("Index");

        }


        //GET
        public IActionResult Upsert(int? id)
        {
             var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            EmployeeTerminationVM employeeTerminationVM = new()
            {
                EmployeeTermination = new(),
                Employeelist = _unitOfWork.Employee.GetAll().Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
                TerminationCategoryList = _unitOfWork.TerminantionCategory.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                

            };

            if (id == null || id == 0)
            {
                employeeTerminationVM.EmployeeTermination.InitiatedById = userId;
                employeeTerminationVM.EmployeeTermination.ApprovalStatus = "Pending";
                employeeTerminationVM.EmployeeTermination.TermDate = DateTime.Now;
                return View(employeeTerminationVM);
            }
            else
            {
                employeeTerminationVM.EmployeeTermination = _unitOfWork.EmployeeTermination.GetFirstOrDefault(u => u.Id == id);
                return View(employeeTerminationVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployeeTerminationVM obj)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                
                if (obj.EmployeeTermination.Id == 0)
                {
                    obj.EmployeeTermination.CreatedBy = userId;
                    _unitOfWork.EmployeeTermination.Add(obj.EmployeeTermination);
					TempData["success"] = "Termination Created Successfully";
				}
                else
                {
                    obj.EmployeeTermination.ModifiedBy = userId;
                    _unitOfWork.EmployeeTermination.Update(obj.EmployeeTermination);
					TempData["success"] = "Termination Updated Successfully";
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
            var employeeTerminationList = _unitOfWork.EmployeeTermination.GetAll(u=>u.Approved==false, includeProperties: "Employee,TerminationCategory");
            if (employeeTerminationList.Count() <= 0)
            {
                TempData["error"] = "No records to Display";
            }
            return Json(new { data = employeeTerminationList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.EmployeeTermination.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }                      

            _unitOfWork.EmployeeTermination.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion
    }
}
