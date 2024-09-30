using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenamedTableNamestohrmremovingDefaultSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "hrm",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "hrm",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "hrm",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "hrm",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "hrm",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                schema: "hrm",
                newName: "TransferredNightshiftHours");

            migrationBuilder.RenameTable(
                name: "Transactions",
                schema: "hrm",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                schema: "hrm",
                newName: "TonnagePosts");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                schema: "hrm",
                newName: "TimeAttendanceRaws");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                schema: "hrm",
                newName: "TerminationCategories");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                schema: "hrm",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "hrm",
                newName: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "hrm",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "hrm",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                schema: "hrm",
                newName: "PnineFiles");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                schema: "hrm",
                newName: "PeriodicalPartProcesss");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                schema: "hrm",
                newName: "periodHistories");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                schema: "hrm",
                newName: "PaySlipTotalEarnings");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                schema: "hrm",
                newName: "PayslipTotalDeductions");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                schema: "hrm",
                newName: "PaySlipPensions");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                schema: "hrm",
                newName: "PayslipPayments");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                schema: "hrm",
                newName: "PayslipPayes");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                schema: "hrm",
                newName: "Payslipnoncashes");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                schema: "hrm",
                newName: "PayslipNhifReliefs");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                schema: "hrm",
                newName: "PayslipMains");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                schema: "hrm",
                newName: "PayslipLoans");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                schema: "hrm",
                newName: "PayslipInsuranceReliefs");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                schema: "hrm",
                newName: "PayslipHousingLevyReliefs");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                schema: "hrm",
                newName: "PaySlipHousingLevies");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                schema: "hrm",
                newName: "PayslipDeductions");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                schema: "hrm",
                newName: "PayrollprocessStages");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                schema: "hrm",
                newName: "PayrollMainReports");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                schema: "hrm",
                newName: "PayrollCodes");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                schema: "hrm",
                newName: "PaymentModes");

            migrationBuilder.RenameTable(
                name: "Payes",
                schema: "hrm",
                newName: "Payes");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                schema: "hrm",
                newName: "OvertimeAbsentTransactions");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                schema: "hrm",
                newName: "OtherPayments");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                schema: "hrm",
                newName: "OrphanedTonnageDatas");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                schema: "hrm",
                newName: "OrphanedNightshiftDatas");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                schema: "hrm",
                newName: "OrderHeaders");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                schema: "hrm",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                schema: "hrm",
                newName: "Nssfs");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                schema: "hrm",
                newName: "NightshiftHoursPostings");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                schema: "hrm",
                newName: "Nhifs");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                schema: "hrm",
                newName: "MonthlyTransferInfos");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                schema: "hrm",
                newName: "Monthlybonuses");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                schema: "hrm",
                newName: "LoanSchedules");

            migrationBuilder.RenameTable(
                name: "Loans",
                schema: "hrm",
                newName: "Loans");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                schema: "hrm",
                newName: "GeneralParameters");

            migrationBuilder.RenameTable(
                name: "Genders",
                schema: "hrm",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                schema: "hrm",
                newName: "EmpResumes");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                schema: "hrm",
                newName: "EmpPinImages");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                schema: "hrm",
                newName: "EmpNssfImages");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                schema: "hrm",
                newName: "EmpNhifImages");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                schema: "hrm",
                newName: "EmployeeTerminations");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                schema: "hrm",
                newName: "EmployeesHoursDays");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "hrm",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                schema: "hrm",
                newName: "EmployeeReactivations");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                schema: "hrm",
                newName: "EmployeeGrades");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                schema: "hrm",
                newName: "EmployeeCategories");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                schema: "hrm",
                newName: "EmployeeAnnualLeaves");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                schema: "hrm",
                newName: "EmpIdImages");

            migrationBuilder.RenameTable(
                name: "Divisions",
                schema: "hrm",
                newName: "Divisions");

            migrationBuilder.RenameTable(
                name: "Departments",
                schema: "hrm",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                schema: "hrm",
                newName: "CurrentPeriods");

            migrationBuilder.RenameTable(
                name: "Currencies",
                schema: "hrm",
                newName: "Currencies");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                schema: "hrm",
                newName: "CPnineFiles");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                schema: "hrm",
                newName: "CPayslipMains");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                schema: "hrm",
                newName: "CPayslipLoans");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                schema: "hrm",
                newName: "CPayrollMainReports");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                schema: "hrm",
                newName: "CoverTypes");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                schema: "hrm",
                newName: "ContractTypes");

            migrationBuilder.RenameTable(
                name: "CompSections",
                schema: "hrm",
                newName: "CompSections");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                schema: "hrm",
                newName: "CompanyBranches");

            migrationBuilder.RenameTable(
                name: "Companies",
                schema: "hrm",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                schema: "hrm",
                newName: "CLoanSchedules");

            migrationBuilder.RenameTable(
                name: "CLoans",
                schema: "hrm",
                newName: "CLoans");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "hrm",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                schema: "hrm",
                newName: "Bonuses");

            migrationBuilder.RenameTable(
                name: "Banks",
                schema: "hrm",
                newName: "Banks");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                schema: "hrm",
                newName: "BankBranches");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                schema: "hrm",
                newName: "AbsentTransactions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "hrm");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "UserTokens",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRoles",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "UserLogins",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "UserClaims",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "User",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                newName: "TransferredNightshiftHours",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transactions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                newName: "TonnagePosts",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                newName: "TimeAttendanceRaws",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                newName: "TerminationCategories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShoppingCarts",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "RoleClaims",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Role",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                newName: "PnineFiles",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                newName: "PeriodicalPartProcesss",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                newName: "periodHistories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                newName: "PaySlipTotalEarnings",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                newName: "PayslipTotalDeductions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                newName: "PaySlipPensions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                newName: "PayslipPayments",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                newName: "PayslipPayes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                newName: "Payslipnoncashes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                newName: "PayslipNhifReliefs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                newName: "PayslipMains",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                newName: "PayslipLoans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                newName: "PayslipInsuranceReliefs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                newName: "PayslipHousingLevyReliefs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                newName: "PaySlipHousingLevies",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                newName: "PayslipDeductions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                newName: "PayrollprocessStages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                newName: "PayrollMainReports",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                newName: "PayrollCodes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                newName: "PaymentModes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Payes",
                newName: "Payes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                newName: "OvertimeAbsentTransactions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                newName: "OtherPayments",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                newName: "OrphanedTonnageDatas",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                newName: "OrphanedNightshiftDatas",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                newName: "OrderHeaders",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetails",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                newName: "Nssfs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                newName: "NightshiftHoursPostings",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                newName: "Nhifs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                newName: "MonthlyTransferInfos",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                newName: "Monthlybonuses",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                newName: "LoanSchedules",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "Loans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                newName: "GeneralParameters",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Genders",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                newName: "EmpResumes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                newName: "EmpPinImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                newName: "EmpNssfImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                newName: "EmpNhifImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                newName: "EmployeeTerminations",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                newName: "EmployeesHoursDays",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                newName: "EmployeeReactivations",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                newName: "EmployeeGrades",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                newName: "EmployeeCategories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                newName: "EmployeeAnnualLeaves",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                newName: "EmpIdImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Divisions",
                newName: "Divisions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Departments",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                newName: "CurrentPeriods",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currencies",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                newName: "CPnineFiles",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                newName: "CPayslipMains",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                newName: "CPayslipLoans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                newName: "CPayrollMainReports",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                newName: "CoverTypes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                newName: "ContractTypes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CompSections",
                newName: "CompSections",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                newName: "CompanyBranches",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Companies",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                newName: "CLoanSchedules",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CLoans",
                newName: "CLoans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                newName: "Bonuses",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Banks",
                newName: "Banks",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                newName: "BankBranches",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                newName: "AbsentTransactions",
                newSchema: "hrm");
        }
    }
}
