using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using SmartHRM.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Diagnostics;
using System.Security.Claims;
using SmartHRM.Models.ViewModels;
using SmartHRM.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace SmartHRMWeb.Areas.Employee.Controllers
{
    [Area("General")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _db;
        private readonly GeneralParameter generalParameter = new GeneralParameter();
        private readonly CurrentPeriod currentPeriod = new CurrentPeriod();
		private readonly IHttpContextAccessor _httpContextAccessor;
		

		public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork,ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _db = db;
            generalParameter = _unitOfWork.GeneralParameter.GetFirstOrDefault(u => u.Id == 1);
            currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);
			_httpContextAccessor = httpContextAccessor;

		}
		
		public IActionResult Index()
        {
            DashBoardVM dashBoardVM = new()
            {
				employeeDashboardVMs = new EmployeeDashboardVM { Employees = _unitOfWork.Employee.GetAll(x=>x.Terminated==false) },
                
			};          
           

            return View(dashBoardVM);
        }



        [HttpGet]
		
		public IActionResult Processperm()
        {
           
            ProcessPermVM processPermVM = new()
            {
                CompanyBranchList = _unitOfWork.CompanyBranch.GetAll().Select(u => new SelectListItem
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
                EmployeeList = _unitOfWork.Employee.GetAll(x => x.Terminated==false).Select(u => new SelectListItem
                {
                    Text = u.FullNameWithCode,
                    Value = u.Id.ToString()
                }),
                DepartmentId = 0,
                CompanyBranchId = 0,
                DivisionId = 0,
                EmployeeId = 0,

            };
            return View(processPermVM);
        }

		[HttpPost]
		public IActionResult Processperm(ProcessPermVM processPermVM)
		{
			var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int BranchId, DivisionId,DepartmentId,EmpId;
            BranchId=DivisionId=DepartmentId=EmpId=0;

            if(processPermVM.CompanyBranchId > 0)
            {				
				BranchId = processPermVM.CompanyBranchId;
            }
			if (processPermVM.DivisionId > 0)
			{
				DivisionId = processPermVM.DivisionId;
			}
			if (processPermVM.DepartmentId > 0)
			{
				DepartmentId = processPermVM.DepartmentId;
			}
			if (processPermVM.EmployeeId > 0)
			{
				EmpId = processPermVM.EmployeeId;
			}

			
			var PYear = new SqlParameter
			{
				ParameterName = "P_Year",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
                Value = 2024
			};
			

			var PDivisionId = new SqlParameter
			{
				ParameterName = "P_DivisionId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = DivisionId
			};
			var PDepartmentId = new SqlParameter
			{
				ParameterName = "P_DepartmentId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = DepartmentId
			};
			var PEmployeeId = new SqlParameter
			{
				ParameterName = "P_EmployeeId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = EmpId
			};
			var PUserId = new SqlParameter
			{
				ParameterName = "P_UserId",
				SqlDbType = System.Data.SqlDbType.VarChar,
				Size = 600,
				Direction = System.Data.ParameterDirection.Input,
				Value = userId
			};
			var PPeriod = new SqlParameter
			{
				ParameterName = "p_Period",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = 5
			};

			var PBranchId = new SqlParameter
			{
				ParameterName = "P_BranchId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = BranchId
			};

			var result = _db.Database.ExecuteSqlRaw($"ProcessPayrollPerm @p_Period,@P_Year,@P_BranchId,@P_DivisionId,@P_DepartmentId,@P_EmployeeId,@P_UserId",
                            PPeriod,
							PYear,
							PBranchId,
							PDivisionId,
							PDepartmentId,
							PEmployeeId,
							PUserId);



			TempData["success"] = "Processing was Successfully";
			return RedirectToAction("Processperm", processPermVM);
		}

		[HttpGet]

		public IActionResult Processcasual()
		{

			ProcessCasualVM processCasualVM = new()
			{
				CompanyBranchList = _unitOfWork.CompanyBranch.GetAll().Select(u => new SelectListItem
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
				EmployeeList = _unitOfWork.Employee.GetAll(x => x.Terminated == false).Select(u => new SelectListItem
				{
					Text = u.FullNameWithCode,
					Value = u.Id.ToString()
				}),				
				DepartmentId = 0,
				CompanyBranchId = 0,
				DivisionId = 0,
                SectionId = 0,
				EmployeeId = 0,
				DateFrom = DateTime.UtcNow,
				DateTo = DateTime.UtcNow

			};
			return View(processCasualVM);
		}

		[HttpPost]
		public IActionResult Processcasual(ProcessCasualVM processcasVM)
		{
			var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
			int BranchId, DivisionId, DepartmentId, EmpId, SectionId;
			BranchId = DivisionId = DepartmentId = EmpId = SectionId= 0;

			DateTime datefrom, dateto;
			datefrom = dateto = DateTime.UtcNow;

			if (processcasVM.CompanyBranchId > 0)
			{
				BranchId = processcasVM.CompanyBranchId;
			}
			if (processcasVM.DivisionId > 0)
			{
				DivisionId = processcasVM.DivisionId;
			}
			if (processcasVM.DepartmentId > 0)
			{
				DepartmentId = processcasVM.DepartmentId;
			}
			if (processcasVM.SectionId > 0)
			{
				SectionId = processcasVM.SectionId;
			}
			if (processcasVM.EmployeeId > 0)
			{
				EmpId = processcasVM.EmployeeId;
			}


			var PYear = new SqlParameter
			{
				ParameterName = "P_Year",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = 2024
			};


			var PDivisionId = new SqlParameter
			{
				ParameterName = "P_DivisionId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = DivisionId
			};
			
			var PDepartmentId = new SqlParameter
			{
				ParameterName = "P_DepartmentId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = DepartmentId
			};
			var PSectionId = new SqlParameter
			{
				ParameterName = "P_SectionId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = SectionId
			};
			var PEmployeeId = new SqlParameter
			{
				ParameterName = "P_EmployeeId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = EmpId
			};
			var PUserId = new SqlParameter
			{
				ParameterName = "P_UserId",
				SqlDbType = System.Data.SqlDbType.VarChar,
				Size = 600,
				Direction = System.Data.ParameterDirection.Input,
				Value = userId
			};
			var PPeriod = new SqlParameter
			{
				ParameterName = "p_Period",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = 5
			};

			var PBranchId = new SqlParameter
			{
				ParameterName = "P_BranchId",
				SqlDbType = System.Data.SqlDbType.Int,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = BranchId
			};
			var PDatefrom = new SqlParameter
			{
				ParameterName = "datefrom",
				SqlDbType = System.Data.SqlDbType.DateTime,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = processcasVM.DateFrom
			};
			var PDateto = new SqlParameter
			{
				ParameterName = "dateto",
				SqlDbType = System.Data.SqlDbType.DateTime,
				Size = 4,
				Direction = System.Data.ParameterDirection.Input,
				Value = processcasVM.DateTo
			};

			var result = _db.Database.ExecuteSqlRaw($"ProcessPayrollCasual @p_Period,@P_Year,@P_BranchId,@P_DivisionId,@P_DepartmentId,@P_SectionId,@P_EmployeeId,@P_UserId,@datefrom,@dateto",
							PPeriod,
							PYear,
							PBranchId,
							PDivisionId,
							PDepartmentId,
                            PSectionId,
							PEmployeeId,
							PUserId,
							PDatefrom,
							PDateto);



			TempData["success"] = "Processing was Successfully";
			return RedirectToAction("Processcasual", processcasVM);
		}


		[HttpGet]
        public IActionResult Closestage(RetrieveStageVM retrieveStageVM)
        {
			var currentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x => x.Id == 1);

            retrieveStageVM = new RetrieveStageVM()
			{
				Stage = currentPeriod.Stage,
				CurrentPeriod = _unitOfWork.CurrentPeriod.GetFirstOrDefault(x=>x.Id==1)
			};
            return View(retrieveStageVM);
        }

		[HttpPost]
        public IActionResult Closestage()
        {
            try
            {
                _db.Database.ExecuteSql($" spClosestage ");
                TempData["success"] = "Stage Closure was Successfully";               

            }
            catch (Exception e)
            {
                TempData["error"] = "Stage Closure failed";               
                throw;
            }



            return RedirectToAction("Index");
        }


		

		[HttpGet]
        public IActionResult Closeperiod(RetrievePeriodDetailsVM retrievePeriodDetailsVM)
        {
            var currentMonthInWordOutPut = new SqlParameter
            {
                ParameterName = "currentMonthInWordOutPut",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 10,
                Direction = System.Data.ParameterDirection.Output,
            };
            var currentYearOutput = new SqlParameter
            {
                ParameterName = "currentYearOutput",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 4,
                Direction = System.Data.ParameterDirection.Output,
            };
            var CurrentPeriodOutPut = new SqlParameter
            {
                ParameterName = "CurrentPeriodOutPut",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 15,
                Direction = System.Data.ParameterDirection.Output,
            };
            var fullcurrent_PeriodOutPut = new SqlParameter
            {
                ParameterName = "fullcurrent_PeriodOutPut",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 20,
                Direction = System.Data.ParameterDirection.Output,
            };
            var currentPeriodStartDate = new SqlParameter
            {
                ParameterName = "currentPeriodStartDate",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 30,
                Direction = System.Data.ParameterDirection.Output,
            };
            var currentPeriodEndDate = new SqlParameter
            {
                ParameterName = "currentPeriodEndDate",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 20,
                Direction = System.Data.ParameterDirection.Output,
            };

            var NextMonthInWordOutPut = new SqlParameter
            {
                ParameterName = "NextMonthInWordOutPut",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 10,
                Direction = System.Data.ParameterDirection.Output,
            };
            var NextYearOutput = new SqlParameter
            {
                ParameterName = "NextYearOutput",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 4,
                Direction = System.Data.ParameterDirection.Output,
            };
            var NextPeriodOutPut = new SqlParameter
            {
                ParameterName = "NextPeriodOutPut",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 15,
                Direction = System.Data.ParameterDirection.Output,
            };
            var fullnext_PeriodOutPut = new SqlParameter
            {
                ParameterName = "fullnext_PeriodOutPut",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 20,
                Direction = System.Data.ParameterDirection.Output,
            };
            var NextPeriodStartdate = new SqlParameter
            {
                ParameterName = "NextPeriodStartdate",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 20,
                Direction = System.Data.ParameterDirection.Output,
            };
            var NextPeriodEnddate = new SqlParameter
            {
                ParameterName = "NextPeriodEnddate",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 20,
                Direction = System.Data.ParameterDirection.Output,
            };

            var result = _db.Database.ExecuteSqlRaw($"spretrieveperiodsdetails @currentMonthInWordOutPut OUTPUT,@currentYearOutput OUTPUT,@CurrentPeriodOutPut OUTPUT,@fullcurrent_PeriodOutPut OUTPUT,@currentPeriodStartDate OUTPUT,@currentPeriodEndDate OUTPUT,@NextMonthInWordOutPut OUTPUT,@NextYearOutput OUTPUT,@NextPeriodOutPut OUTPUT,@fullnext_PeriodOutPut OUTPUT,@NextPeriodStartdate OUTPUT,@NextPeriodEnddate OUTPUT", currentMonthInWordOutPut,
                            currentYearOutput,
                            CurrentPeriodOutPut,
                            fullcurrent_PeriodOutPut,
                            currentPeriodStartDate,
                            currentPeriodEndDate,
                            NextMonthInWordOutPut,
                            NextYearOutput,
                            NextPeriodOutPut,
                            fullnext_PeriodOutPut,
                            NextPeriodStartdate,
                            NextPeriodEnddate);


             retrievePeriodDetailsVM = new()
            {
                Closeperiod = new(),
            };

            retrievePeriodDetailsVM.Closeperiod.currentMonthInWordOutPut = currentMonthInWordOutPut.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.currentYearOutput = currentYearOutput.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.CurrentPeriodOutPut = CurrentPeriodOutPut.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.fullcurrent_PeriodOutPut = fullcurrent_PeriodOutPut.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.currentPeriodStartDate = currentPeriodStartDate.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.currentPeriodEndDate = currentPeriodEndDate.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.NextMonthInWordOutPut = NextMonthInWordOutPut.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.NextPeriodOutPut = NextPeriodOutPut.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.NextYearOutput = NextYearOutput.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.fullnext_PeriodOutPut = fullnext_PeriodOutPut.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.NextPeriodStartdate = NextPeriodStartdate.Value.ToString();
            retrievePeriodDetailsVM.Closeperiod.NextPeriodEnddate = NextPeriodEnddate.Value.ToString();
            return View(retrievePeriodDetailsVM);
        }


		[HttpPost]
		public IActionResult Closeperiod()
		{
			try
			{
				// 'Check whether the payroll has been processed before closing
				PayslipMain payslipmain = _unitOfWork.PayslipMain.GetFirstOrDefault(u => u.PayPeriod == currentPeriod.CurrentMonth && u.PayYear == currentPeriod.Year);
				if (payslipmain == null)
				{
					TempData["error"] = "This month payroll has not been processed.Period Cannot be closed in this state.";
					
					return RedirectToAction("Closeperiod");
				}
				//Check whether there is unapproved transactions
				Transaction transaction = _unitOfWork.Transaction.GetFirstOrDefault(u => u.Period == currentPeriod.CurrentMonth && u.TransYear == currentPeriod.Year && u.Approved == false);
				if (transaction != null)
				{
					TempData["error"] = "There are un-approved Transactions.\"Period Cannot be closed in this state.";
                    return View();
                }

				//Close the Period
				var result = _db.Database.ExecuteSqlRaw($" spClosePeriod ");
				TempData["success"] = "The Process was successful";
				return View();
			}
			catch (Exception e)
			{
				throw;
			}

		}
		public IActionResult Details(int productId)
        {
            ShoppingCart cartObj = new()
            {
                Count = 1,
                ProductId = productId,
                Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == productId, includeProperties: "Category,CoverType")
            };

            return View(cartObj);
        }

        

		//These methods facilitate cascading

		[HttpPost]
		
		public IActionResult Divisions()
		{
			MemoryStream stream = new MemoryStream();
			Request.Body.CopyToAsync(stream);
			stream.Position = 0;
			using StreamReader reader = new StreamReader(stream);
			string requestBody = reader.ReadToEnd();
			if (requestBody.Length > 0)
			{
				//var divisions = _unitOfWork.Division.GetAll(x => x.CompanyBranchId == Convert.ToInt32(requestBody)).Select(c => new { Id = c.Id, Name = c.DivisionName }).ToList();
				var divisions =_unitOfWork.Division.GetAll(x => x.CompanyBranchId == Convert.ToInt32(requestBody));
				return new JsonResult(divisions);
			}
			return null;
		}

		[HttpPost]
		public IActionResult Sections()
		{
			MemoryStream stream = new MemoryStream();
			Request.Body.CopyToAsync(stream);
			stream.Position = 0;
			using StreamReader reader = new StreamReader(stream);
			string requestBody = reader.ReadToEnd();
			if (requestBody.Length > 0)
			{
				//var divisions = _unitOfWork.Division.GetAll(x => x.CompanyBranchId == Convert.ToInt32(requestBody)).Select(c => new { Id = c.Id, Name = c.DivisionName }).ToList();
				var sections = _unitOfWork.CompSection.GetAll(x => x.DepartmentId == Convert.ToInt32(requestBody));
				return new JsonResult(sections);
			}
			return null;
		}

		[HttpPost]
		public IActionResult Departments()
        {
            MemoryStream stream = new MemoryStream();
            Request.Body.CopyToAsync(stream);
            stream.Position = 0;
            using StreamReader reader = new StreamReader(stream);
            string requestBody = reader.ReadToEnd();
            if (requestBody.Length > 0)
            {                
				var departments = _unitOfWork.Department.GetAll(x => x.DivisionId == Convert.ToInt32(requestBody));
				return new JsonResult(departments);
            }
            return null;
        }


		[HttpPost]
		public IActionResult Employees()
		{
			MemoryStream stream = new MemoryStream();
			Request.Body.CopyToAsync(stream);
			stream.Position = 0;
			using StreamReader reader = new StreamReader(stream);
			string requestBody = reader.ReadToEnd();
			if (requestBody.Length > 0)
			{
				var employees = _unitOfWork.Employee.GetAll(x => x.Terminated == false && x.DepartmentId == Convert.ToInt32(requestBody));
				return new JsonResult(employees);
			}
			return null;
		}


		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}