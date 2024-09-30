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
	public class EmployeeReactivationController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmployeeReactivationController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<EmployeeReactivation> employeeReactivationList = _unitOfWork.EmployeeReactivation.GetAll(u => u.Approved == false, includeProperties: "Employee");

            return View(employeeReactivationList);
        }
        public IActionResult ApproveReactivation()
        {
            IEnumerable<EmployeeReactivation> employeeReactivationList = _unitOfWork.EmployeeReactivation.GetAll(u => u.Approved == false, includeProperties: "Employee");

            return View(employeeReactivationList);

        }

        //Post
        [HttpPost]
        public async Task<IActionResult> ApproveReactivation([FromBody] int[] ids)
        {
            string result = string.Empty;
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                if (ids.Count() > 0)
                {
                    foreach (int id in ids)
                    {
                        var data = _db.EmployeeReactivations.Where(e => e.Id == id).FirstOrDefault();
                        if (data != null)
                        {
                            data.Approved = true;
                            data.ApprovedById = userId;
                            data.ApprovalDate = DateTime.Now;
                            data.ApprovalStatus = "Approved";
                            _db.Update(data);
                        }

                        var updateEmpstatus = _db.Employees.Where(u=>u.Id==data.EmployeeId).FirstOrDefault();
                        if (updateEmpstatus != null) 
                        { 
                            updateEmpstatus.Terminated = false;
                            _db.Update(updateEmpstatus);
                        }
                    }
                    await _db.SaveChangesAsync();
                    TempData["success"] = "Reactivation Approval Successfully";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View();

        }


        //GET
        public IActionResult Upsert(int? id)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            EmployeeReactivationVM employeeReactivationVM = new()
            {
                EmployeeReactivation = new(),
                Employeelist = _unitOfWork.EmployeeTermination.GetAll(includeProperties: "Employee").Select(u => new SelectListItem
                {
                    Text = u.Employee.FullNameWithCode,
                    Value = u.Employee.Id.ToString()
                })            

            };

            if (id == null || id == 0)
            {
                employeeReactivationVM.EmployeeReactivation.InitiatedById = userId;
                employeeReactivationVM.EmployeeReactivation.ApprovalStatus = "Pending";
                employeeReactivationVM.EmployeeReactivation.ReturnDate = DateTime.Now;
                return View(employeeReactivationVM);
            }
            else
            {
                employeeReactivationVM.EmployeeReactivation = _unitOfWork.EmployeeReactivation.GetFirstOrDefault(u => u.Id == id);
                return View(employeeReactivationVM);
            }

        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployeeReactivationVM obj)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                
                if (obj.EmployeeReactivation.Id == 0)
                {
                    obj.EmployeeReactivation.CreatedBy= userId;
                    _unitOfWork.EmployeeReactivation.Add(obj.EmployeeReactivation);
					TempData["success"] = "Reactivation Created Successfully";
				}
                else
                {
                    obj.EmployeeReactivation.ModifiedBy = userId;
                    _unitOfWork.EmployeeReactivation.Update(obj.EmployeeReactivation);
					TempData["success"] = "Reactivation Updated Successfully";
				}

                _unitOfWork.Save();
                
                //TempData["success"] = "Product Created Successfully";
                return RedirectToAction("Upsert");
            }
            return View(obj);

        }



        #region API-CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var employeeReactivationList = _unitOfWork.EmployeeReactivation.GetAll(u=>u.Approved==false, includeProperties: "Employee");
            return Json(new { data = employeeReactivationList });
        }

        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.EmployeeReactivation.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
                      

            _unitOfWork.EmployeeReactivation.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion
    }
}
