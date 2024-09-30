using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCasualTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    LoanDesc = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LoanTransDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanStartPeriod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LoanEndPeriod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NoInterest = table.Column<bool>(type: "bit", nullable: false),
                    Reducing = table.Column<bool>(type: "bit", nullable: false),
                    Fixed = table.Column<bool>(type: "bit", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlyRecoveryAmnt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RND = table.Column<int>(type: "int", nullable: false),
                    NumberOfPeriods = table.Column<int>(type: "int", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UseStageRecov = table.Column<bool>(type: "bit", nullable: false),
                    Cleared = table.Column<bool>(type: "bit", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CLoans_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CLoans_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLoanSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<int>(type: "int", nullable: false),
                    PaymentNumber = table.Column<int>(type: "int", nullable: false),
                    Icharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceBF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StageRecov = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CummulativeInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLoanSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CLoanSchedules_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPayrollMainReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPayrollMainReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPayrollMainReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPayslipMains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    PayYear = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhifNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NssfNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PersonalRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentModeId = table.Column<int>(type: "int", nullable: false),
                    BankID = table.Column<int>(type: "int", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankBranchID = table.Column<int>(type: "int", nullable: false),
                    BankBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompBranch = table.Column<int>(type: "int", nullable: false),
                    BasicBalanceToDate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    HoursDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    HouseAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateEmployed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Savings = table.Column<bool>(type: "bit", nullable: false),
                    Tonnage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPayslipMains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPayslipMains_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPayslipMains_PaymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Monthlybonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxable = table.Column<bool>(type: "bit", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BalancePay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Datefrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dateto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RateValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monthlybonuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monthlybonuses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monthlybonuses_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLoans_EmployeeId",
                table: "CLoans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CLoans_PayrollCodeId",
                table: "CLoans",
                column: "PayrollCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CLoanSchedules_LoanId",
                table: "CLoanSchedules",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_CPayrollMainReports_EmployeeId",
                table: "CPayrollMainReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CPayslipMains_EmployeeId",
                table: "CPayslipMains",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CPayslipMains_PaymentModeId",
                table: "CPayslipMains",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Monthlybonuses_EmployeeId",
                table: "Monthlybonuses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Monthlybonuses_PayrollCodeId",
                table: "Monthlybonuses",
                column: "PayrollCodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLoans");

            migrationBuilder.DropTable(
                name: "CLoanSchedules");

            migrationBuilder.DropTable(
                name: "CPayrollMainReports");

            migrationBuilder.DropTable(
                name: "CPayslipMains");

            migrationBuilder.DropTable(
                name: "Monthlybonuses");
        }
    }
}
