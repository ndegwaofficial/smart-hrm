using SmartHRM.DataAccess;
using SmartHRM.DataAccess.Repository;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHRMWeb.Areas.Employee.Controllers;
using System.Security.Claims;
using PIMS.Web.Common;
using PIMS.Models.ViewModels;
using SmartHRM.Utility.Constants;

namespace SmartHRMWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.RoleSuperAdmin)]
	public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EmployeeController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {          

            return View();
        }

        public IActionResult View(int? id)
        {
            EmployeeVM employeeVM = new()
            {
                Employee = _unitOfWork.Employee.GetFirstOrDefault(u => u.Id == id, includeProperties: "Department,Gender,ContractType,EmployeeCategory"),
				ListIdFiles = _unitOfWork.EmpIdImage.GetAll(x => x.EmployeeId == id),
				ListNssfFiles = _unitOfWork.EmpNssfImage.GetAll(x => x.EmployeeId == id),
				ListNhifFiles = _unitOfWork.EmpNhifImage.GetAll(x => x.EmployeeId == id),
				ListPinFiles = _unitOfWork.EmpPinImage.GetAll(x => x.EmployeeId == id),
				ListResumeFiles = _unitOfWork.EmpResumeImage.GetAll(x => x.EmployeeId == id)
			};
			
			return View(employeeVM);
		}



		[HttpGet]
		public IActionResult UploadPinImage(int? id)
		{
			EmpPinImageVM empPinImageVM = new();

			if (id == null || id == 0)
			{
				return View(empPinImageVM);
			}
			else
			{
				empPinImageVM.employee = _unitOfWork.Employee.GetFirstOrDefault(u => u.Id == id);
				return View(empPinImageVM);
			}
		}


		//Post
		[HttpPost]
		public async Task<IActionResult> UploadPinImage(EmpPinImageVM obj)
		{
			int EmpId = obj.employee.Id;
			var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
			foreach (var file in obj.PFormFile)
			{
				if (file.Length > 0)
				{
					using (var memorySteam = new MemoryStream())
					{
						await file.CopyToAsync(memorySteam);
						byte[] reducedImage = memorySteam.ToArray();

						var empPinImage = new EmpPinImage()
						{
							FileName = obj.FileName,
							CreatedBy = userId,
							DateCreated = DateTime.UtcNow,
							EmployeeId = obj.employee.Id,
							Content = reducedImage.ToArray()
						};

						_unitOfWork.EmpPinImage.Add(empPinImage);

					}
				}

			}
			_unitOfWork.Save();
			return RedirectToAction("View", new { id = EmpId });
		}

		//Resume
		[HttpGet]
		public IActionResult UploadResumeImage(int? id)
		{
			EmpResumeImageVM empResumeImageVM = new();

			if (id == null || id == 0)
			{
				return View(empResumeImageVM);
			}
			else
			{
				empResumeImageVM.employee = _unitOfWork.Employee.GetFirstOrDefault(u => u.Id == id);
				return View(empResumeImageVM);
			}
		}


		//Post
		[HttpPost]
		public async Task<IActionResult> UploadResumeImage(EmpResumeImageVM obj)
		{
			int EmpId = obj.employee.Id;
			var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
			foreach (var file in obj.PFormFile)
			{
				if (file.Length > 0)
				{
					using (var memorySteam = new MemoryStream())
					{
						await file.CopyToAsync(memorySteam);
						byte[] reducedImage = memorySteam.ToArray();

						var empResumeImage = new EmpResume()
						{
							FileName = obj.FileName,
							CreatedBy = userId,
							DateCreated = DateTime.UtcNow,
							EmployeeId = obj.employee.Id,
							Content = reducedImage.ToArray()
						};

						_unitOfWork.EmpResumeImage.Add(empResumeImage);

					}
				}

			}
			_unitOfWork.Save();

			TempData["success"] = "Resume Uploaded Successfully";
			return RedirectToAction("View", new { id = EmpId });
		}

		//Resume



		[HttpGet]
		public IActionResult UploadNhifImage(int? id)
		{
			EmpNhifImageVM empNhifImageVM = new();

			if (id == null || id == 0)
			{
				return View(empNhifImageVM);
			}
			else
			{
				empNhifImageVM.employee = _unitOfWork.Employee.GetFirstOrDefault(u => u.Id == id);
				
				return View(empNhifImageVM);
			}
		}


		//Post
		[HttpPost]
		public async Task<IActionResult> UploadNhifImage(EmpNhifImageVM obj)
		{
			int EmpId = obj.employee.Id;
			var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
			foreach (var file in obj.PFormFile)
			{
				if (file.Length > 0)
				{
					using (var memorySteam = new MemoryStream())
					{
						await file.CopyToAsync(memorySteam);
						byte[] reducedImage = memorySteam.ToArray();

						var empNhifImage = new EmpNhifImage()
						{
							FileName = obj.FileName,
							CreatedBy = userId,
							DateCreated = DateTime.UtcNow,
							EmployeeId = obj.employee.Id,
							Content = reducedImage.ToArray()
						};

						_unitOfWork.EmpNhifImage.Add(empNhifImage);

					}
				}

			}
			_unitOfWork.Save();
			TempData["success"] = "NHIF Uploaded Successfully";
			return RedirectToAction("View", new { id = EmpId });
		}





		[HttpGet]
		public IActionResult UploadNssfImage(int? id)
		{
			EmpNssfImageVM empNssfImageVM = new();

			if (id == null || id == 0)
			{
				return View(empNssfImageVM);
			}
			else
			{
				empNssfImageVM.employee = _unitOfWork.Employee.GetFirstOrDefault(u => u.Id == id);
				return View(empNssfImageVM);
			}
		}


		//Post
		[HttpPost]
		public async Task<IActionResult> UploadNssfImage(EmpNssfImageVM obj)
		{
			int EmpId = obj.employee.Id;
			var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
			foreach (var file in obj.PFormFile)
			{
				if (file.Length > 0)
				{
					using (var memorySteam = new MemoryStream())
					{
						await file.CopyToAsync(memorySteam);
						byte[] reducedImage = memorySteam.ToArray();

						var empNssfImage = new EmpNssfImage()
						{
							FileName = obj.FileName,
							CreatedBy = userId,
							DateCreated = DateTime.UtcNow,
							EmployeeId = obj.employee.Id,
							Content = reducedImage.ToArray()
						};

						_unitOfWork.EmpNssfImage.Add(empNssfImage);

					}
				}

			}
			_unitOfWork.Save();
			TempData["success"] = "NSSF Uploaded Successfully";
			return RedirectToAction("View", new { id = EmpId });
		}

		[HttpGet]
		public IActionResult UploadIdImage(int? id)
		{
			EmpIdImageVM empIdImageVM = new();

			if (id == null || id == 0)
			{
				return View(empIdImageVM);
			}
			else
			{
				empIdImageVM.employee = _unitOfWork.Employee.GetFirstOrDefault(u => u.Id == id);
				return View(empIdImageVM);
			}
		}


		//Post
		[HttpPost]
		public async Task<IActionResult> UploadIdImage(EmpIdImageVM obj)
		{
			int EmpId = obj.employee.Id;
			var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
			foreach (var file in obj.PFormFile)
			{
				if (file.Length > 0) 
				{
					using (var memorySteam = new MemoryStream())
					{
						await file.CopyToAsync(memorySteam);
						byte[] reducedImage = memorySteam.ToArray();

						var empIdImage = new EmpIdImage()
						{
							FileName = obj.FileName,
							CreatedBy = userId,
							DateCreated = DateTime.UtcNow,
							EmployeeId = obj.employee.Id,
							Content = reducedImage.ToArray()
						};

						_unitOfWork.EmpIdImage.Add(empIdImage);

					}
				}

			}
			_unitOfWork.Save();
			TempData["success"] = "ID Uploaded Successfully";
			return RedirectToAction("View", new { id = EmpId });
		}

		//Post
		//[HttpDelete]
		public IActionResult DeleteId(int? id)
		{

			var obj = _unitOfWork.EmpIdImage.GetFirstOrDefault(u => u.Id == id);
			if (obj == null)
			{
				return Json(new { success = false, message = "Error while deleting" });
			}

			_unitOfWork.EmpIdImage.Remove(obj);
			_unitOfWork.Save();
			TempData["success"] = "ID Deleted Successfully";
			return Json(new { success = true, message = "Delete Successful" });

		}

		//Post
		//[HttpDelete]
		public IActionResult DeleteResume(int? id)
		{

			var obj = _unitOfWork.EmpResumeImage.GetFirstOrDefault(u => u.Id == id);
			if (obj == null)
			{
				return Json(new { success = false, message = "Error while deleting" });
			}

			_unitOfWork.EmpResumeImage.Remove(obj);
			_unitOfWork.Save();
			TempData["success"] = "Resume Deleted Successfully";
			return Json(new { success = true, message = "Delete Successful" });

		}

		//Post
		//[HttpDelete]
		public IActionResult DeleteNssfId(int? id)
		{

			var obj = _unitOfWork.EmpNssfImage.GetFirstOrDefault(u => u.Id == id);
			if (obj == null)
			{
				return Json(new { success = false, message = "Error while deleting" });
			}

			_unitOfWork.EmpNssfImage.Remove(obj);
			_unitOfWork.Save();
			TempData["success"] = "N.S.S.F Deleted Successfully";
			return Json(new { success = true, message = "Delete Successful" });

		}

		//Post
		//[HttpDelete]
		public IActionResult DeletePinImage(int? id)
		{

			var obj = _unitOfWork.EmpPinImage.GetFirstOrDefault(u => u.Id == id);
			if (obj == null)
			{
				return Json(new { success = false, message = "Error while deleting" });
			}

			_unitOfWork.EmpPinImage.Remove(obj);
			_unitOfWork.Save();
			TempData["success"] = "P.I.N Deleted Successfully";
			return Json(new { success = true, message = "Delete Successful" });

		}


		//Post
		//[HttpDelete]
		public async Task<IActionResult> DeleteNhifId(int? id)
		{

			var obj = _unitOfWork.EmpNhifImage.GetFirstOrDefault(u => u.Id == id);
			if (obj == null)
			{
				return Json(new { success = false, message = "Error while deleting" });
			}

			_unitOfWork.EmpNhifImage.Remove(obj);
			_unitOfWork.Save();
			TempData["success"] = "N.H.I.F Deleted Successfully";
			return Json(new { success = true, message = "Delete Successful" });

		}

		[HttpGet]
		public async Task<FileResult> GetEmpResumeImageFile(int id)
		{
			var empResumeImage = _unitOfWork.EmpResumeImage.GetFirstOrDefault(x => x.Id == id);

			 return  File(empResumeImage.Content.ToArray(), "application/pdf");
		}


		[HttpGet]
		public async Task<FileResult> GetEmpIdImageFile(int id)
		{
			var empidImage = _unitOfWork.EmpIdImage.GetFirstOrDefault(x => x.Id == id);

			return File(empidImage.Content.ToArray(), "application/pdf");
		}

		[HttpGet]
		public async Task<FileResult> GetEmpPinImageFile(int id)
		{
			var empidImage = _unitOfWork.EmpPinImage.GetFirstOrDefault(x => x.Id == id);

			return File(empidImage.Content.ToArray(), "application/pdf");
		}


		[HttpGet]
		public async Task<FileResult> GetEmpNssfImageFile(int id)
		{
			var empidImage = _unitOfWork.EmpNssfImage.GetFirstOrDefault(x => x.Id == id);

			return File(empidImage.Content.ToArray(), "application/pdf");
		}

		[HttpGet]
		public async Task<FileResult> GetEmpNhifImageFile(int id)
		{
			var empidImage = _unitOfWork.EmpNhifImage.GetFirstOrDefault(x => x.Id == id);

			return File(empidImage.Content.ToArray(), "application/pdf");
		}

		//GET
		public IActionResult Upsert(int? id)
        {
            EmployeeVM employeeVM = new()
            {
                Employee = new(),
                GenderList = _unitOfWork.Gender.GetAll().Select(u => new SelectListItem
                {
                    Text = u.GenderName,
                    Value = u.Id.ToString()
                }),
                CurrencyList = _unitOfWork.Currency.GetAll().Select(u => new SelectListItem
                {
                    Text = u.CurrencyName,
                    Value = u.Id.ToString()
                }),
                ContracttypeList = _unitOfWork.ContractType.GetAll().Select(u => new SelectListItem
                {
                    Text = u.TypeName,
                    Value = u.Id.ToString()
                }),                
                GradeList = _unitOfWork.EmployeeGrade.GetAll().Select(u => new SelectListItem
                {
                    Text = u.GradeName,
                    Value = u.Id.ToString()
                }),
                CompBranchList = _unitOfWork.CompanyBranch.GetAll().Select(u => new SelectListItem
                {
                    Text = u.CompanyBranchName,
                    Value = u.Id.ToString()
                }),
                DivisionList = _unitOfWork.Division.GetAll().Select(u => new SelectListItem
                {
                    Text = u.DivisionName,
                    Value = u.Id.ToString()
                }),
                DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
                {
                    Text = u.DepartmentName,
                    Value = u.Id.ToString()
                }),
                SectionList = _unitOfWork.CompSection.GetAll().Select(u => new SelectListItem
                {
                    Text = u.SectionName,
                    Value = u.Id.ToString()
                }),
                BankList = _unitOfWork.Bank.GetAll().Select(u => new SelectListItem
                {
                    Text = u.BankName,
                    Value = u.Id.ToString()
                }),
                BankBranchList = _unitOfWork.BankBranch.GetAll().Select(u => new SelectListItem
                {
                    Text = u.BankBranchName,
                    Value = u.Id.ToString()
                }),
				CategoryList = _unitOfWork.EmployeeCategory.GetAll().Select(u=>new SelectListItem
                {
                    Text = u.CategoryName,
                    Value = u.Id.ToString()
                })

			};
           
            if (id == null || id == 0)
            {                
                return View(employeeVM);
            }
            else
            {
                employeeVM.Employee = _unitOfWork.Employee.GetFirstOrDefault(u => u.Id == id);
                return View(employeeVM);
            }
         
            
        }

		

		//Post
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(EmployeeVM obj)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
               
                //string wwwRootPath = _hostEnvironment.WebRootPath;
                if(obj.PFormFile != null)
                {
                    var file = obj.PFormFile;

                    if (file.Length > 0)
                    {
                        using (var memorySteam = new MemoryStream())
                        {
                            await file.CopyToAsync(memorySteam);
                            byte[] reducedImage = CommonFunctions.ReduceImage(memorySteam.ToArray());

                            obj.Employee.FileName = file.FileName;
                            obj.Employee.Content = reducedImage.ToArray();

                        }
                    }
                }
                if(obj.Employee.Id==0)
                {
                    obj.Employee.CreatedBy = userId;
                    _unitOfWork.Employee.Add(obj.Employee);
                }
                else
                {
                    obj.Employee.ModifiedBy = userId;
                    _unitOfWork.Employee.Update(obj.Employee);
                }
                
                _unitOfWork.Save();
                if(obj.Employee.Id ==0) 
                {
                    TempData["success"] = "Employee Created Successfully";
                }
                else
                {
                    TempData["success"] = "Employee Updated Successfully";
                }
                //TempData["success"] = "Product Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }



        #region API-CALLS

        [HttpGet]
        public async Task<FileResult> GetEmployeeImageFile(int id)
        {
            var EmpImage = _unitOfWork.Employee.GetFirstOrDefault(x => x.Id == id);

            return File(EmpImage.Content.ToArray(), "image/jpeg");
        } 
        [HttpGet]
        public IActionResult GetAll()
        {
            var employeeList = _unitOfWork.Employee.GetAll(x => x.Terminated == false, includeProperties:"Department,Gender");
            return Json(new {data= employeeList });
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetEmployees()
        {
            var employeeList = _unitOfWork.Employee.GetAll(x=>x.Terminated==false,includeProperties: "Department,Gender");
            return Json(new { data = employeeList });
        }


        //Post
        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var obj = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return Json(new {success=false,message="Error while deleting"});
            }

            var oldImagePath = Path.Combine(_hostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }

		public IActionResult Divisions(int? selectedBranch)
		{
			
			if (selectedBranch != 0)
			{
                
				IEnumerable<Division> divisions = _unitOfWork.Division.GetAll(u=>u.CompanyBranchId == selectedBranch);
				return new JsonResult(divisions);
			}
			return null;
		}

		public IActionResult Departments(int selectedDivision)
		{
			
			if (selectedDivision != 0)
			{
				IEnumerable<Department> departments = _unitOfWork.Department.GetAll(u=>u.DivisionId==selectedDivision);
				return new JsonResult(departments);
			}
			return null;
		}


		public IActionResult Sections(int selectedDepartment)
		{
			
			if (selectedDepartment != 0)
			{
				IEnumerable<CompSection> sections = _unitOfWork.CompSection.GetAll(u=>u.DepartmentId==selectedDepartment);
				return new JsonResult(sections);
			}
			return null;
		}

		public IActionResult Bankbranches(int selectedBank)
		{
			
			if (selectedBank != 0)
			{
				IEnumerable<BankBranch> bankbranches = _unitOfWork.BankBranch.GetAll(u=>u.BankId== selectedBank);
				return new JsonResult(bankbranches);
			}
			return null;
		}


		#endregion

	}

}
