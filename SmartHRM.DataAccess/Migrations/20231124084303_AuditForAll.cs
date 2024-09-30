using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuditForAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Transactions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TerminationCategories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "TerminationCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "TerminationCategories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "TerminationCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PnineFiles",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PnineFiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PnineFiles",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PnineFiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PeriodicalPartProcesss",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PeriodicalPartProcesss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PeriodicalPartProcesss",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PeriodicalPartProcesss",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "periodHistories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "periodHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "periodHistories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "periodHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaySlipTotalEarnings",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PaySlipTotalEarnings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaySlipTotalEarnings",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PaySlipTotalEarnings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipTotalDeductions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipTotalDeductions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipTotalDeductions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipTotalDeductions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaySlipPensions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PaySlipPensions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaySlipPensions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PaySlipPensions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipPayments",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipPayments",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipPayments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipPayes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipPayes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipPayes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipPayes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Payslipnoncashes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Payslipnoncashes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Payslipnoncashes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Payslipnoncashes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipNhifReliefs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipNhifReliefs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipNhifReliefs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipNhifReliefs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipMains",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipMains",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipMains",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipMains",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipLoans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipLoans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipLoans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipLoans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipInsuranceReliefs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipInsuranceReliefs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipInsuranceReliefs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipInsuranceReliefs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaySlipHousingLevies",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PaySlipHousingLevies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaySlipHousingLevies",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PaySlipHousingLevies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayslipDeductions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayslipDeductions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayslipDeductions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayslipDeductions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayrollprocessStages",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayrollprocessStages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayrollprocessStages",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayrollprocessStages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayrollMainReports",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayrollMainReports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayrollMainReports",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayrollMainReports",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PayrollCodes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PayrollCodes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PayrollCodes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PayrollCodes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaymentModes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PaymentModes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaymentModes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PaymentModes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Payes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Payes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Payes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Payes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OvertimeAbsentTransactions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "OvertimeAbsentTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "OvertimeAbsentTransactions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "OvertimeAbsentTransactions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Nssfs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Nssfs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Nssfs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Nssfs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Nhifs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Nhifs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Nhifs",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Nhifs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MonthlyTransferInfos",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "MonthlyTransferInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MonthlyTransferInfos",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MonthlyTransferInfos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Monthlybonuses",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Monthlybonuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Monthlybonuses",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Monthlybonuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LoanSchedules",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "LoanSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "LoanSchedules",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "LoanSchedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Loans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Loans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Loans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Genders",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Genders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Genders",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Genders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeTerminations",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "EmployeeTerminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "EmployeeTerminations",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmployeeTerminations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeesHoursDays",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "EmployeesHoursDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "EmployeesHoursDays",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmployeesHoursDays",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Employees",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Employees",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeReactivations",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "EmployeeReactivations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "EmployeeReactivations",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmployeeReactivations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeGrades",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "EmployeeGrades",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "EmployeeGrades",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmployeeGrades",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeCategories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "EmployeeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "EmployeeCategories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmployeeCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeAnnualLeaves",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "EmployeeAnnualLeaves",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "EmployeeAnnualLeaves",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmployeeAnnualLeaves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Divisions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Divisions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Divisions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Divisions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Departments",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Departments",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CurrentPeriods",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CurrentPeriods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CurrentPeriods",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CurrentPeriods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CPnineFiles",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CPnineFiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CPnineFiles",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CPnineFiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CPayslipMains",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CPayslipMains",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CPayslipMains",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CPayslipMains",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CPayslipLoans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CPayslipLoans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CPayslipLoans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CPayslipLoans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CPayrollMainReports",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CPayrollMainReports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CPayrollMainReports",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CPayrollMainReports",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CoverTypes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CoverTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CoverTypes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CoverTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ContractTypes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ContractTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "ContractTypes",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ContractTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CompSections",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CompSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CompSections",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CompSections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CompanyBranches",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CompanyBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CompanyBranches",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CompanyBranches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Companies",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Companies",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CLoanSchedules",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CLoanSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CLoanSchedules",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CLoanSchedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CLoans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CLoans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CLoans",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CLoans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Categories",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Bonuses",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Bonuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Bonuses",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Bonuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Banks",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Banks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Banks",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Banks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BankBranches",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "BankBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "BankBranches",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "BankBranches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AbsentTransactions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AbsentTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "AbsentTransactions",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AbsentTransactions",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TerminationCategories");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "TerminationCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TerminationCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "TerminationCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PnineFiles");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PnineFiles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PnineFiles");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PnineFiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PeriodicalPartProcesss");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PeriodicalPartProcesss");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PeriodicalPartProcesss");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PeriodicalPartProcesss");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "periodHistories");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "periodHistories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "periodHistories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "periodHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaySlipTotalEarnings");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PaySlipTotalEarnings");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaySlipTotalEarnings");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PaySlipTotalEarnings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipTotalDeductions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipTotalDeductions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipTotalDeductions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipTotalDeductions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaySlipPensions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PaySlipPensions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaySlipPensions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PaySlipPensions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipPayments");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipPayments");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipPayments");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipPayments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipPayes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipPayes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipPayes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipPayes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Payslipnoncashes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Payslipnoncashes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Payslipnoncashes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Payslipnoncashes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipNhifReliefs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipNhifReliefs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipNhifReliefs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipNhifReliefs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipMains");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipMains");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipMains");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipMains");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipLoans");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipLoans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipLoans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipLoans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipInsuranceReliefs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipInsuranceReliefs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipInsuranceReliefs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipInsuranceReliefs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaySlipHousingLevies");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PaySlipHousingLevies");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaySlipHousingLevies");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PaySlipHousingLevies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayslipDeductions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayslipDeductions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayslipDeductions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayslipDeductions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayrollprocessStages");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayrollprocessStages");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayrollprocessStages");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayrollprocessStages");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayrollMainReports");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayrollMainReports");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayrollMainReports");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayrollMainReports");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PayrollCodes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PayrollCodes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PayrollCodes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PayrollCodes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaymentModes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PaymentModes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaymentModes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PaymentModes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Payes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Payes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Payes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Payes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OvertimeAbsentTransactions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "OvertimeAbsentTransactions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "OvertimeAbsentTransactions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "OvertimeAbsentTransactions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Nssfs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Nssfs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Nssfs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Nssfs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Nhifs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Nhifs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Nhifs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Nhifs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MonthlyTransferInfos");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "MonthlyTransferInfos");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MonthlyTransferInfos");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MonthlyTransferInfos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Monthlybonuses");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Monthlybonuses");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Monthlybonuses");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Monthlybonuses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LoanSchedules");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "LoanSchedules");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LoanSchedules");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "LoanSchedules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeesHoursDays");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EmployeesHoursDays");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "EmployeesHoursDays");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "EmployeesHoursDays");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeReactivations");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EmployeeReactivations");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "EmployeeReactivations");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "EmployeeReactivations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeGrades");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EmployeeGrades");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "EmployeeGrades");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "EmployeeGrades");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeCategories");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EmployeeCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "EmployeeCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "EmployeeCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeAnnualLeaves");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EmployeeAnnualLeaves");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "EmployeeAnnualLeaves");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "EmployeeAnnualLeaves");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CurrentPeriods");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CurrentPeriods");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CurrentPeriods");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CurrentPeriods");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CPnineFiles");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CPnineFiles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CPnineFiles");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CPnineFiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CPayslipMains");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CPayslipMains");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CPayslipMains");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CPayslipMains");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CPayslipLoans");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CPayslipLoans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CPayslipLoans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CPayslipLoans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CPayrollMainReports");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CPayrollMainReports");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CPayrollMainReports");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CPayrollMainReports");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CoverTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ContractTypes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ContractTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "ContractTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ContractTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CompSections");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CompSections");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CompSections");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CompSections");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CompanyBranches");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CompanyBranches");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CompanyBranches");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CompanyBranches");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CLoanSchedules");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CLoanSchedules");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CLoanSchedules");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CLoanSchedules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CLoans");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CLoans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CLoans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CLoans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Bonuses");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Bonuses");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Bonuses");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Bonuses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AbsentTransactions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AbsentTransactions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AbsentTransactions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AbsentTransactions");
        }
    }
}
