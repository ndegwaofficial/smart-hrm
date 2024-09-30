using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAnnualData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PaymentModes_PaymentModeId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeeAnnualLeaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CurrentMonth = table.Column<int>(type: "int", nullable: false),
                    CurrentYear = table.Column<int>(type: "int", nullable: false),
                    LeaveAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAnnualLeaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAnnualLeaves_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAnnualLeaves_EmployeeId",
                table: "EmployeeAnnualLeaves",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PaymentModes_PaymentModeId",
                table: "Employees",
                column: "PaymentModeId",
                principalTable: "PaymentModes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PaymentModes_PaymentModeId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeAnnualLeaves");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PaymentModes_PaymentModeId",
                table: "Employees",
                column: "PaymentModeId",
                principalTable: "PaymentModes",
                principalColumn: "Id");
        }
    }
}
