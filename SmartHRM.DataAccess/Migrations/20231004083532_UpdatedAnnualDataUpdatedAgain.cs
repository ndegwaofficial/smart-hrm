using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAnnualDataUpdatedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAnnualLeaves_PayrollCodeId",
                table: "EmployeeAnnualLeaves",
                column: "PayrollCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAnnualLeaves_PayrollCodes_PayrollCodeId",
                table: "EmployeeAnnualLeaves",
                column: "PayrollCodeId",
                principalTable: "PayrollCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAnnualLeaves_PayrollCodes_PayrollCodeId",
                table: "EmployeeAnnualLeaves");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeAnnualLeaves_PayrollCodeId",
                table: "EmployeeAnnualLeaves");
        }
    }
}
