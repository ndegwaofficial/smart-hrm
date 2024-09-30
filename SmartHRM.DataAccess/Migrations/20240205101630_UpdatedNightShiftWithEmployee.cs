using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedNightShiftWithEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "TransferredNightshiftHours",
                newName: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferredNightshiftHours_EmployeeId",
                table: "TransferredNightshiftHours",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransferredNightshiftHours_Employees_EmployeeId",
                table: "TransferredNightshiftHours",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransferredNightshiftHours_Employees_EmployeeId",
                table: "TransferredNightshiftHours");

            migrationBuilder.DropIndex(
                name: "IX_TransferredNightshiftHours_EmployeeId",
                table: "TransferredNightshiftHours");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "TransferredNightshiftHours",
                newName: "EmpId");
        }
    }
}
