using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "UserTokens",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRoles",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "UserLogins",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "UserClaims",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "User",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                newName: "TransferredNightshiftHours",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transactions",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                newName: "TonnagePosts",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                newName: "TimeAttendanceRaws",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                newName: "TerminationCategories",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "RoleClaims",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Role",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                newName: "PnineFiles",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                newName: "PeriodicalPartProcesss",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                newName: "periodHistories",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                newName: "PaySlipTotalEarnings",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                newName: "PayslipTotalDeductions",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                newName: "PaySlipPensions",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                newName: "PayslipPayments",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                newName: "PayslipPayes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                newName: "Payslipnoncashes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                newName: "PayslipNhifReliefs",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                newName: "PayslipMains",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                newName: "PayslipLoans",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                newName: "PayslipInsuranceReliefs",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                newName: "PayslipHousingLevyReliefs",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                newName: "PaySlipHousingLevies",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                newName: "PayslipDeductions",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                newName: "PayrollprocessStages",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                newName: "PayrollMainReports",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                newName: "PayrollCodes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                newName: "PaymentModes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Payes",
                newName: "Payes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                newName: "OvertimeAbsentTransactions",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                newName: "OtherPayments",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                newName: "OrphanedTonnageDatas",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                newName: "OrphanedNightshiftDatas",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                newName: "Nssfs",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                newName: "NightshiftHoursPostings",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                newName: "Nhifs",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                newName: "MonthlyTransferInfos",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                newName: "Monthlybonuses",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                newName: "LoanSchedules",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "Loans",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                newName: "GeneralParameters",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Genders",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                newName: "EmpResumes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                newName: "EmpPinImages",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                newName: "EmpNssfImages",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                newName: "EmpNhifImages",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                newName: "EmployeeTerminations",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                newName: "EmployeesHoursDays",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                newName: "EmployeeReactivations",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                newName: "EmployeeGrades",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                newName: "EmployeeCategories",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                newName: "EmployeeAnnualLeaves",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                newName: "EmpIdImages",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Divisions",
                newName: "Divisions",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Departments",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                newName: "CurrentPeriods",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currencies",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                newName: "CPnineFiles",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                newName: "CPayslipMains",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                newName: "CPayslipLoans",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                newName: "CPayrollMainReports",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                newName: "CoverTypes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                newName: "ContractTypes",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CompSections",
                newName: "CompSections",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                newName: "CompanyBranches",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Companies",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                newName: "CLoanSchedules",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "CLoans",
                newName: "CLoans",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                newName: "Bonuses",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "Banks",
                newName: "Banks",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                newName: "BankBranches",
                newSchema: "SmartHRM");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                newName: "AbsentTransactions",
                newSchema: "SmartHRM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "SmartHRM",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "SmartHRM",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "SmartHRM",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "SmartHRM",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "SmartHRM",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                schema: "SmartHRM",
                newName: "TransferredNightshiftHours");

            migrationBuilder.RenameTable(
                name: "Transactions",
                schema: "SmartHRM",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                schema: "SmartHRM",
                newName: "TonnagePosts");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                schema: "SmartHRM",
                newName: "TimeAttendanceRaws");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                schema: "SmartHRM",
                newName: "TerminationCategories");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "SmartHRM",
                newName: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "SmartHRM",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "SmartHRM",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                schema: "SmartHRM",
                newName: "PnineFiles");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                schema: "SmartHRM",
                newName: "PeriodicalPartProcesss");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                schema: "SmartHRM",
                newName: "periodHistories");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                schema: "SmartHRM",
                newName: "PaySlipTotalEarnings");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                schema: "SmartHRM",
                newName: "PayslipTotalDeductions");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                schema: "SmartHRM",
                newName: "PaySlipPensions");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                schema: "SmartHRM",
                newName: "PayslipPayments");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                schema: "SmartHRM",
                newName: "PayslipPayes");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                schema: "SmartHRM",
                newName: "Payslipnoncashes");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                schema: "SmartHRM",
                newName: "PayslipNhifReliefs");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                schema: "SmartHRM",
                newName: "PayslipMains");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                schema: "SmartHRM",
                newName: "PayslipLoans");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                schema: "SmartHRM",
                newName: "PayslipInsuranceReliefs");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                schema: "SmartHRM",
                newName: "PayslipHousingLevyReliefs");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                schema: "SmartHRM",
                newName: "PaySlipHousingLevies");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                schema: "SmartHRM",
                newName: "PayslipDeductions");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                schema: "SmartHRM",
                newName: "PayrollprocessStages");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                schema: "SmartHRM",
                newName: "PayrollMainReports");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                schema: "SmartHRM",
                newName: "PayrollCodes");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                schema: "SmartHRM",
                newName: "PaymentModes");

            migrationBuilder.RenameTable(
                name: "Payes",
                schema: "SmartHRM",
                newName: "Payes");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                schema: "SmartHRM",
                newName: "OvertimeAbsentTransactions");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                schema: "SmartHRM",
                newName: "OtherPayments");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                schema: "SmartHRM",
                newName: "OrphanedTonnageDatas");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                schema: "SmartHRM",
                newName: "OrphanedNightshiftDatas");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                schema: "SmartHRM",
                newName: "Nssfs");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                schema: "SmartHRM",
                newName: "NightshiftHoursPostings");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                schema: "SmartHRM",
                newName: "Nhifs");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                schema: "SmartHRM",
                newName: "MonthlyTransferInfos");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                schema: "SmartHRM",
                newName: "Monthlybonuses");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                schema: "SmartHRM",
                newName: "LoanSchedules");

            migrationBuilder.RenameTable(
                name: "Loans",
                schema: "SmartHRM",
                newName: "Loans");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                schema: "SmartHRM",
                newName: "GeneralParameters");

            migrationBuilder.RenameTable(
                name: "Genders",
                schema: "SmartHRM",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                schema: "SmartHRM",
                newName: "EmpResumes");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                schema: "SmartHRM",
                newName: "EmpPinImages");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                schema: "SmartHRM",
                newName: "EmpNssfImages");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                schema: "SmartHRM",
                newName: "EmpNhifImages");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                schema: "SmartHRM",
                newName: "EmployeeTerminations");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                schema: "SmartHRM",
                newName: "EmployeesHoursDays");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "SmartHRM",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                schema: "SmartHRM",
                newName: "EmployeeReactivations");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                schema: "SmartHRM",
                newName: "EmployeeGrades");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                schema: "SmartHRM",
                newName: "EmployeeCategories");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                schema: "SmartHRM",
                newName: "EmployeeAnnualLeaves");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                schema: "SmartHRM",
                newName: "EmpIdImages");

            migrationBuilder.RenameTable(
                name: "Divisions",
                schema: "SmartHRM",
                newName: "Divisions");

            migrationBuilder.RenameTable(
                name: "Departments",
                schema: "SmartHRM",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                schema: "SmartHRM",
                newName: "CurrentPeriods");

            migrationBuilder.RenameTable(
                name: "Currencies",
                schema: "SmartHRM",
                newName: "Currencies");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                schema: "SmartHRM",
                newName: "CPnineFiles");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                schema: "SmartHRM",
                newName: "CPayslipMains");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                schema: "SmartHRM",
                newName: "CPayslipLoans");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                schema: "SmartHRM",
                newName: "CPayrollMainReports");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                schema: "SmartHRM",
                newName: "CoverTypes");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                schema: "SmartHRM",
                newName: "ContractTypes");

            migrationBuilder.RenameTable(
                name: "CompSections",
                schema: "SmartHRM",
                newName: "CompSections");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                schema: "SmartHRM",
                newName: "CompanyBranches");

            migrationBuilder.RenameTable(
                name: "Companies",
                schema: "SmartHRM",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                schema: "SmartHRM",
                newName: "CLoanSchedules");

            migrationBuilder.RenameTable(
                name: "CLoans",
                schema: "SmartHRM",
                newName: "CLoans");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "SmartHRM",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                schema: "SmartHRM",
                newName: "Bonuses");

            migrationBuilder.RenameTable(
                name: "Banks",
                schema: "SmartHRM",
                newName: "Banks");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                schema: "SmartHRM",
                newName: "BankBranches");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                schema: "SmartHRM",
                newName: "AbsentTransactions");
        }
    }
}
