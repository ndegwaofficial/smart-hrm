using SmartHRM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace SmartHRM.DataAccess
{
    public class ApplicationDbContext:IdentityDbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("SmartHRM");
            builder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           

            var insertedEntries = this.ChangeTracker.Entries()
                                   .Where(x => x.State == EntityState.Added)
                                   .Select(x => x.Entity);

            foreach (var insertedEntry in insertedEntries)
            {
                var auditableEntity = insertedEntry as BaseModel;
                //If the inserted object is an Auditable. 
                if (auditableEntity != null)
                {
                    auditableEntity.DateCreated = DateTime.UtcNow;
                   // auditableEntity.CreatedBy = "Felix";
                }
            }

            var modifiedEntries = this.ChangeTracker.Entries()
                       .Where(x => x.State == EntityState.Modified)
                       .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                //If the inserted object is an Auditable. 
                var auditableEntity = modifiedEntry as BaseModel;
                if (auditableEntity != null)
                {
                    auditableEntity.ModifiedDate = DateTime.UtcNow;
                    //auditableEntity.ModifiedBy = "Felix Aduol";
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            var insertedEntries = this.ChangeTracker.Entries()
                                   .Where(x => x.State == EntityState.Added)
                                   .Select(x => x.Entity);

            foreach (var insertedEntry in insertedEntries)
            {
                var auditableEntity = insertedEntry as BaseModel;
                //If the inserted object is an Auditable. 
                if (auditableEntity != null)
                {
                    auditableEntity.DateCreated = DateTime.UtcNow;
                    //auditableEntity.CreatedBy = "Felix";
                }
            }

            var modifiedEntries = this.ChangeTracker.Entries()
                       .Where(x => x.State == EntityState.Modified)
                       .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                //If the inserted object is an Auditable. 
                var auditableEntity = modifiedEntry as BaseModel;
                if (auditableEntity != null)
                {
                    auditableEntity.ModifiedDate = DateTime.UtcNow;
                    //auditableEntity.ModifiedBy = "Felix Aduol";
                }
            }

            return base.SaveChanges();
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Company> Companies { get; set; }
      

		//HRM ITEMS
		public DbSet<CompanyBranch> CompanyBranches { get; set; }
		public DbSet<Division> Divisions { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<CompSection> CompSections { get; set; }
		public DbSet<Bank> Banks { get; set; }
		public DbSet<BankBranch> BankBranches { get; set; }
		public DbSet<Gender> Genders { get; set; }
		public DbSet<ContractType> ContractTypes { get; set; }
		public DbSet<Currency> Currencies { get; set; }	
		public DbSet<EmployeeGrade> EmployeeGrades { get; set; }
		public DbSet<EmployeeCategory> EmployeeCategories { get; set; }
		public DbSet<Employee> Employees { get; set; }
        public DbSet<Paye> Payes { get; set; }
        public DbSet<Nhif> Nhifs { get; set; }
        public DbSet<Nssf> Nssfs { get; set; }
        public DbSet<PayrollCode> PayrollCodes { get; set; }
        public DbSet<PayrollprocessStage> PayrollprocessStages { get; set; }
        public DbSet<EmployeesHoursDay> EmployeesHoursDays { get; set; }
        public DbSet<GeneralParameter> GeneralParameters { get; set; }
        public DbSet<CurrentPeriod> CurrentPeriods { get; set; }
        public DbSet<TimeAttendanceRaw> TimeAttendanceRaws { get; set; }
        public DbSet<OvertimeAbsentTransaction> OvertimeAbsentTransactions { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanSchedule> LoanSchedules { get; set;}    

        //Payslip Tables
        public DbSet<PayslipPayment> PayslipPayments { get; set; }
        public DbSet<PayslipTotalDeduction> PayslipTotalDeductions { get; set; }
        public DbSet<PaySlipPension> PaySlipPensions { get; set; }
        public DbSet<PaySlipTotalEarning> PaySlipTotalEarnings { get; set; }
        public DbSet<PayslipPaye>PayslipPayes { get; set; }
		public DbSet<Payslipnoncash> Payslipnoncashes { get; set; }
		public DbSet<PayslipNhifRelief> PayslipNhifReliefs { get; set; }
		public DbSet<PayslipMain> PayslipMains { get; set; }
		public DbSet<PayslipInsuranceRelief> PayslipInsuranceReliefs { get; set; }
		public DbSet<PaySlipHousingLevy> PaySlipHousingLevies { get; set; }
		public DbSet<PayslipHousingLevyRelief> PayslipHousingLevyReliefs { get; set; }

		public DbSet<PayslipLoan> PayslipLoans { get; set; }
		public DbSet<PayslipDeduction> PayslipDeductions { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
        public DbSet<PeriodicalPartProcess> PeriodicalPartProcesss { get; set; }
        public DbSet<AbsentTransaction> AbsentTransactions { get; set; }
        public DbSet<PaymentMode> PaymentModes { get; set; }
        public DbSet<EmployeeAnnualLeave> EmployeeAnnualLeaves { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<OtherPayment>OtherPayments { get; set; }
        public DbSet<MonthlyTransferInfo> MonthlyTransferInfos { get; set;}
        public DbSet<PnineFile> PnineFiles { get; set;}
        public DbSet<CPnineFile> CPnineFiles { get; set; }
        public DbSet<PayrollMainReport> PayrollMainReports { get; set; }
        public DbSet<PeriodHistory> periodHistories { get; set; }
        public DbSet<Monthlybonus> Monthlybonuses { get; set; }
        public DbSet<CLoan> CLoans { get; set; }
        public DbSet<CLoanSchedule> CLoanSchedules { get; set; }
        public DbSet<CPayrollMainReport> CPayrollMainReports { get; set; }
        public DbSet<CPayslipMain> CPayslipMains { get; set; }
        public DbSet<CPayslipLoan> CPayslipLoans { get; set; }
        public DbSet<TerminationCategory> TerminationCategories { get; set;}
        public DbSet<EmployeeTermination> EmployeeTerminations { get; set; }
        public DbSet<EmployeeReactivation> EmployeeReactivations { get; set; }       
        public DbSet<TonnagePosting> TonnagePosts { get; set; } 
        public DbSet<OrphanedTonnageData>OrphanedTonnageDatas { get; set; }
        public DbSet<NightshiftHoursPosting> NightshiftHoursPostings { get; set; }
        public DbSet<OrphanedNightshiftData>OrphanedNightshiftDatas { get; set; }

        public DbSet<TransferredNightshiftHours>TransferredNightshiftHours { get; set; }
        public DbSet<EmpIdImage>EmpIdImages { get; set; }
		public DbSet<EmpNssfImage> EmpNssfImages { get; set; }
		public DbSet<EmpNhifImage> EmpNhifImages { get; set; }
		public DbSet<EmpPinImage> EmpPinImages { get; set; }
		public DbSet<EmpResume> EmpResumes { get; set; }




	}
}
