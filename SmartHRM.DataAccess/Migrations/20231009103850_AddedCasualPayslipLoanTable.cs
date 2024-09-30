using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCasualPayslipLoanTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPayslipLoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    LoanName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoantMonthlyPrincipal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Periodx = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LoanNo = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPayslipLoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPayslipLoans_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPayslipLoans_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPayslipLoans_EmployeeId",
                table: "CPayslipLoans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CPayslipLoans_PayrollCodeId",
                table: "CPayslipLoans",
                column: "PayrollCodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPayslipLoans");
        }
    }
}
