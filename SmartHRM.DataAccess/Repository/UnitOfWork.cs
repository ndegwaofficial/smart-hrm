using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CovertypeRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);            
           
			CompanyBranch = new CompanyBranchRepository(_db);
            Division = new DivisionRepository(_db);
            Department = new DepartmentRepository(_db); 
            CompSection= new CompSectionRepository(_db);
            Bank= new BankRepository(_db);
            BankBranch= new BankBranchRepository(_db);
            Gender= new GenderRepository(_db);
            Currency = new CurrencyRepository(_db);
            ContractType = new ContractTypeRepository(_db);          
			EmployeeGrade = new EmployeeGradeRepository(_db);
            Employee = new EmployeeRepository(_db);
            EmployeeCategory= new EmployeeCategoryRepository(_db);
            Paye = new PayeRepository(_db);
            Nhif = new NhifRepository(_db);
            Nssf = new NssfRepository(_db);
            PayrollCode = new PayrollCodeRepository(_db);
            PayrollprocessStage = new PayrollprocessStageRepository(_db);
            EmployeesHoursDay = new EmployeesHoursDayRepository(_db);
            GeneralParameter = new GeneralParameterRepository(_db);
            CurrentPeriod = new CurrentPeriodRepository(_db);
            TimeAttendanceRaw = new TimeAttendanceRawRepository(_db);
            OvertimeAbsentTransaction = new OvertimeAbsentTransactionRepository(_db);
            Loan = new LoanRepository(_db);
            LoanSchedule = new LoanScheduleRepository(_db);
            AbsentTransaction = new AbsentTransactionRepository(_db);
            Transaction = new TransactionRepository(_db);
            PaymentMode = new PaymentModeRepository(_db);
            CLoan = new CLoanRepository(_db);
            CLoanSchedule = new CLoanScheduleRepository(_db);
            PayslipMain = new PayslipMainRepository(_db);
            TerminantionCategory = new TerminantionCategoryRepository(_db);
            EmployeeTermination = new EmployeeTerminationRepository(_db);
            EmployeeReactivation = new EmployeeReactivationRepository(_db);
            PayslipMain = new PayslipMainRepository(_db);
            NightShiftHoursPosting = new NightShiftPostingHoursRepository(_db);
            TransferredNightshiftHours = new TransferredNightshiftHoursRepository(_db);
            EmpIdImage = new EmpIdImageRepository(_db); 
            EmpNssfImage  = new EmpNssfImageRepository(_db);
            EmpNhifImage = new EmpNhifImageRepository(_db);
            EmpPinImage = new EmpPinImageRepository(_db);
			EmpResumeImage = new EmpResumeImageRepository(_db);



		}

        public ICategoryRepository Category { get; private set; }
        public ICovertypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
		
		//HRM
		public ICompanyBranchRepository CompanyBranch { get; private set; }
		public IDivisionRepository Division { get; private set; }
		public IDepartmentRepository Department { get; private set; }
        public ICompSectionRepository CompSection { get;private set; }
		public IBankRepository Bank { get; private set; }
		public IBankBranchRepository BankBranch { get; private set; }
		public IGenderRepository Gender { get; private set; }
        public IContractTypeRepository ContractType { get; private set; }  
        public ICurrencyRepository Currency { get; private set; }
	    public IEmployeeGradeRepository EmployeeGrade { get; private set; }
        public IEmployeeRepository Employee { get; private set; }
        public IEmployeeCategoryRepository EmployeeCategory { get; private set; }
        public IPayeRepository Paye { get; private set; }
        public INhifRepository Nhif { get; private set; }
        public INssfRepository Nssf { get; private set; }
        public IPayrollCodeRepository PayrollCode { get; private set; }

        public IPayrollprocessStageRepository PayrollprocessStage { get; private set; }
        public IEmployeesHoursDayRepository EmployeesHoursDay { get; private set; }
        public IGeneralParameterRepository GeneralParameter { get; private set; }
        public ICurrentPeriodRepository CurrentPeriod { get; private set; }
        public ITimeAttendanceRawRepository TimeAttendanceRaw { get; private set; }
        public IOvertimeAbsentTransactionRepository OvertimeAbsentTransaction { get; private set; }
        public ILoanRepository Loan { get; private set; }
        public ILoanScheduleRepository LoanSchedule { get; private set; }
        public IAbsentTransactionRepository AbsentTransaction { get; private set; }
        public ITransactionRepository Transaction { get; private set; } 
        public IPaymentModeRepository PaymentMode { get; private set; }
        public ICLoanRepository CLoan { get; private set; }
        public ICLoanScheduleRepository CLoanSchedule { get; private set; }
        public ITerminantionCategoryRepository TerminantionCategory { get; private set; }
        public IEmployeeTerminationRepository EmployeeTermination { get; private set; }
        public IEmployeeReactivationRepository EmployeeReactivation { get; private set; }
        public IPayslipMainRepository PayslipMain { get; private set; }
        public INightShiftHoursPostingRepository NightShiftHoursPosting { get; private set; }
        public ITransferredNightshiftHoursRepository TransferredNightshiftHours { get; private set; }
		public IEmpIdImageRepository EmpIdImage { get; private set; }
        public IEmpNssfImageRepository EmpNssfImage { get; private set; }
        public IEmpNhifImageRepository EmpNhifImage { get; private set; }
        public IEmpPinImageRepository EmpPinImage { get; private set; }
        public IEmpResumeImageRepository EmpResumeImage { get; private set; }


		public void Save()
        {
            _db.SaveChanges();
           
        }
    }
}
