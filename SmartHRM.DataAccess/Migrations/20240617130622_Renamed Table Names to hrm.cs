using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenamedTableNamestohrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "hrm");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Identity",
                newName: "UserTokens",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Identity",
                newName: "UserRoles",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Identity",
                newName: "UserLogins",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Identity",
                newName: "UserClaims",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Identity",
                newName: "User",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                schema: "Identity",
                newName: "TransferredNightshiftHours",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Transactions",
                schema: "Identity",
                newName: "Transactions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                schema: "Identity",
                newName: "TonnagePosts",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                schema: "Identity",
                newName: "TimeAttendanceRaws",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                schema: "Identity",
                newName: "TerminationCategories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                schema: "Identity",
                newName: "ShoppingCarts",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Identity",
                newName: "RoleClaims",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Identity",
                newName: "Role",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Identity",
                newName: "Products",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                schema: "Identity",
                newName: "PnineFiles",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                schema: "Identity",
                newName: "PeriodicalPartProcesss",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                schema: "Identity",
                newName: "periodHistories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                schema: "Identity",
                newName: "PaySlipTotalEarnings",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                schema: "Identity",
                newName: "PayslipTotalDeductions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                schema: "Identity",
                newName: "PaySlipPensions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                schema: "Identity",
                newName: "PayslipPayments",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                schema: "Identity",
                newName: "PayslipPayes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                schema: "Identity",
                newName: "Payslipnoncashes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                schema: "Identity",
                newName: "PayslipNhifReliefs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                schema: "Identity",
                newName: "PayslipMains",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                schema: "Identity",
                newName: "PayslipLoans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                schema: "Identity",
                newName: "PayslipInsuranceReliefs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                schema: "Identity",
                newName: "PayslipHousingLevyReliefs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                schema: "Identity",
                newName: "PaySlipHousingLevies",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                schema: "Identity",
                newName: "PayslipDeductions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                schema: "Identity",
                newName: "PayrollprocessStages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                schema: "Identity",
                newName: "PayrollMainReports",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                schema: "Identity",
                newName: "PayrollCodes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                schema: "Identity",
                newName: "PaymentModes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Payes",
                schema: "Identity",
                newName: "Payes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                schema: "Identity",
                newName: "OvertimeAbsentTransactions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                schema: "Identity",
                newName: "OtherPayments",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                schema: "Identity",
                newName: "OrphanedTonnageDatas",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                schema: "Identity",
                newName: "OrphanedNightshiftDatas",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                schema: "Identity",
                newName: "OrderHeaders",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                schema: "Identity",
                newName: "OrderDetails",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                schema: "Identity",
                newName: "Nssfs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                schema: "Identity",
                newName: "NightshiftHoursPostings",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                schema: "Identity",
                newName: "Nhifs",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                schema: "Identity",
                newName: "MonthlyTransferInfos",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                schema: "Identity",
                newName: "Monthlybonuses",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                schema: "Identity",
                newName: "LoanSchedules",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Loans",
                schema: "Identity",
                newName: "Loans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                schema: "Identity",
                newName: "GeneralParameters",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Genders",
                schema: "Identity",
                newName: "Genders",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                schema: "Identity",
                newName: "EmpResumes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                schema: "Identity",
                newName: "EmpPinImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                schema: "Identity",
                newName: "EmpNssfImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                schema: "Identity",
                newName: "EmpNhifImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                schema: "Identity",
                newName: "EmployeeTerminations",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                schema: "Identity",
                newName: "EmployeesHoursDays",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "Identity",
                newName: "Employees",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                schema: "Identity",
                newName: "EmployeeReactivations",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                schema: "Identity",
                newName: "EmployeeGrades",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                schema: "Identity",
                newName: "EmployeeCategories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                schema: "Identity",
                newName: "EmployeeAnnualLeaves",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                schema: "Identity",
                newName: "EmpIdImages",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Divisions",
                schema: "Identity",
                newName: "Divisions",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Departments",
                schema: "Identity",
                newName: "Departments",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                schema: "Identity",
                newName: "CurrentPeriods",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Currencies",
                schema: "Identity",
                newName: "Currencies",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                schema: "Identity",
                newName: "CPnineFiles",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                schema: "Identity",
                newName: "CPayslipMains",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                schema: "Identity",
                newName: "CPayslipLoans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                schema: "Identity",
                newName: "CPayrollMainReports",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                schema: "Identity",
                newName: "CoverTypes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                schema: "Identity",
                newName: "ContractTypes",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CompSections",
                schema: "Identity",
                newName: "CompSections",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                schema: "Identity",
                newName: "CompanyBranches",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Companies",
                schema: "Identity",
                newName: "Companies",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                schema: "Identity",
                newName: "CLoanSchedules",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "CLoans",
                schema: "Identity",
                newName: "CLoans",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "Identity",
                newName: "Categories",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                schema: "Identity",
                newName: "Bonuses",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "Banks",
                schema: "Identity",
                newName: "Banks",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                schema: "Identity",
                newName: "BankBranches",
                newSchema: "hrm");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                schema: "Identity",
                newName: "AbsentTransactions",
                newSchema: "hrm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "hrm",
                newName: "UserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "hrm",
                newName: "UserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "hrm",
                newName: "UserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "hrm",
                newName: "UserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "hrm",
                newName: "User",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                schema: "hrm",
                newName: "TransferredNightshiftHours",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Transactions",
                schema: "hrm",
                newName: "Transactions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                schema: "hrm",
                newName: "TonnagePosts",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                schema: "hrm",
                newName: "TimeAttendanceRaws",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                schema: "hrm",
                newName: "TerminationCategories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                schema: "hrm",
                newName: "ShoppingCarts",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "hrm",
                newName: "RoleClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "hrm",
                newName: "Role",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "hrm",
                newName: "Products",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                schema: "hrm",
                newName: "PnineFiles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                schema: "hrm",
                newName: "PeriodicalPartProcesss",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                schema: "hrm",
                newName: "periodHistories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                schema: "hrm",
                newName: "PaySlipTotalEarnings",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                schema: "hrm",
                newName: "PayslipTotalDeductions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                schema: "hrm",
                newName: "PaySlipPensions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                schema: "hrm",
                newName: "PayslipPayments",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                schema: "hrm",
                newName: "PayslipPayes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                schema: "hrm",
                newName: "Payslipnoncashes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                schema: "hrm",
                newName: "PayslipNhifReliefs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                schema: "hrm",
                newName: "PayslipMains",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                schema: "hrm",
                newName: "PayslipLoans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                schema: "hrm",
                newName: "PayslipInsuranceReliefs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                schema: "hrm",
                newName: "PayslipHousingLevyReliefs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                schema: "hrm",
                newName: "PaySlipHousingLevies",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                schema: "hrm",
                newName: "PayslipDeductions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                schema: "hrm",
                newName: "PayrollprocessStages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                schema: "hrm",
                newName: "PayrollMainReports",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                schema: "hrm",
                newName: "PayrollCodes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                schema: "hrm",
                newName: "PaymentModes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Payes",
                schema: "hrm",
                newName: "Payes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                schema: "hrm",
                newName: "OvertimeAbsentTransactions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                schema: "hrm",
                newName: "OtherPayments",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                schema: "hrm",
                newName: "OrphanedTonnageDatas",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                schema: "hrm",
                newName: "OrphanedNightshiftDatas",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                schema: "hrm",
                newName: "OrderHeaders",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                schema: "hrm",
                newName: "OrderDetails",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                schema: "hrm",
                newName: "Nssfs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                schema: "hrm",
                newName: "NightshiftHoursPostings",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                schema: "hrm",
                newName: "Nhifs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                schema: "hrm",
                newName: "MonthlyTransferInfos",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                schema: "hrm",
                newName: "Monthlybonuses",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                schema: "hrm",
                newName: "LoanSchedules",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Loans",
                schema: "hrm",
                newName: "Loans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                schema: "hrm",
                newName: "GeneralParameters",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Genders",
                schema: "hrm",
                newName: "Genders",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                schema: "hrm",
                newName: "EmpResumes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                schema: "hrm",
                newName: "EmpPinImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                schema: "hrm",
                newName: "EmpNssfImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                schema: "hrm",
                newName: "EmpNhifImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                schema: "hrm",
                newName: "EmployeeTerminations",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                schema: "hrm",
                newName: "EmployeesHoursDays",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "hrm",
                newName: "Employees",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                schema: "hrm",
                newName: "EmployeeReactivations",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                schema: "hrm",
                newName: "EmployeeGrades",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                schema: "hrm",
                newName: "EmployeeCategories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                schema: "hrm",
                newName: "EmployeeAnnualLeaves",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                schema: "hrm",
                newName: "EmpIdImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Divisions",
                schema: "hrm",
                newName: "Divisions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Departments",
                schema: "hrm",
                newName: "Departments",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                schema: "hrm",
                newName: "CurrentPeriods",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Currencies",
                schema: "hrm",
                newName: "Currencies",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                schema: "hrm",
                newName: "CPnineFiles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                schema: "hrm",
                newName: "CPayslipMains",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                schema: "hrm",
                newName: "CPayslipLoans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                schema: "hrm",
                newName: "CPayrollMainReports",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                schema: "hrm",
                newName: "CoverTypes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                schema: "hrm",
                newName: "ContractTypes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CompSections",
                schema: "hrm",
                newName: "CompSections",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                schema: "hrm",
                newName: "CompanyBranches",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Companies",
                schema: "hrm",
                newName: "Companies",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                schema: "hrm",
                newName: "CLoanSchedules",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CLoans",
                schema: "hrm",
                newName: "CLoans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "hrm",
                newName: "Categories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                schema: "hrm",
                newName: "Bonuses",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Banks",
                schema: "hrm",
                newName: "Banks",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                schema: "hrm",
                newName: "BankBranches",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                schema: "hrm",
                newName: "AbsentTransactions",
                newSchema: "Identity");
        }
    }
}
