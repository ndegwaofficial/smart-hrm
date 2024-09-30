using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICovertypeRepository CoverType { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
		
		//HRM
		ICompanyBranchRepository CompanyBranch { get; }
		IDivisionRepository Division { get; }
        IDepartmentRepository Department { get; }
        ICompSectionRepository CompSection { get; }
        IBankRepository Bank { get; }
        IBankBranchRepository BankBranch { get; }
        IGenderRepository Gender { get; }
		IContractTypeRepository ContractType { get; }
		ICurrencyRepository Currency { get; }
        IEmployeeGradeRepository EmployeeGrade { get; }
        IEmployeeCategoryRepository EmployeeCategory { get; }
        IEmployeeRepository Employee { get; }
        IPayeRepository Paye { get; }
        INhifRepository Nhif { get; }
        INssfRepository Nssf { get; }
        IPayrollCodeRepository PayrollCode { get; }


        IPayrollprocessStageRepository PayrollprocessStage { get; }

        IEmployeesHoursDayRepository EmployeesHoursDay { get; }
        IGeneralParameterRepository GeneralParameter { get; }
        ICurrentPeriodRepository CurrentPeriod { get; }

        ITimeAttendanceRawRepository TimeAttendanceRaw { get; }
        IOvertimeAbsentTransactionRepository OvertimeAbsentTransaction { get; }
        ILoanRepository Loan{ get; }
        ILoanScheduleRepository LoanSchedule { get; }
        IAbsentTransactionRepository AbsentTransaction { get; }
        ITransactionRepository Transaction { get; }
        IPaymentModeRepository PaymentMode { get; }
        ICLoanRepository CLoan { get; }
        ICLoanScheduleRepository CLoanSchedule { get; }
        ITerminantionCategoryRepository TerminantionCategory { get; }
        IEmployeeTerminationRepository EmployeeTermination { get; }
        IEmployeeReactivationRepository EmployeeReactivation { get; }
        IPayslipMainRepository PayslipMain { get; }
        INightShiftHoursPostingRepository NightShiftHoursPosting { get; }
        ITransferredNightshiftHoursRepository TransferredNightshiftHours { get; } 
        IEmpIdImageRepository EmpIdImage { get; }
        IEmpNssfImageRepository EmpNssfImage { get; }   
        IEmpNhifImageRepository EmpNhifImage { get; }
        IEmpPinImageRepository EmpPinImage { get; }
		IEmpResumeImageRepository EmpResumeImage { get; }


		void Save();
    }
}
