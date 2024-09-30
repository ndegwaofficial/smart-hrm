using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAttendaceRaw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpNationalId",
                table: "TimeAttendanceRaws");

            migrationBuilder.RenameColumn(
                name: "Synid",
                table: "TimeAttendanceRaws",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "TimeAttendanceRaws",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TimeAttendanceRaws_EmployeeId",
                table: "TimeAttendanceRaws",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeAttendanceRaws_Employees_EmployeeId",
                table: "TimeAttendanceRaws",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeAttendanceRaws_Employees_EmployeeId",
                table: "TimeAttendanceRaws");

            migrationBuilder.DropIndex(
                name: "IX_TimeAttendanceRaws_EmployeeId",
                table: "TimeAttendanceRaws");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "TimeAttendanceRaws");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "TimeAttendanceRaws",
                newName: "Synid");

            migrationBuilder.AddColumn<string>(
                name: "EmpNationalId",
                table: "TimeAttendanceRaws",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
