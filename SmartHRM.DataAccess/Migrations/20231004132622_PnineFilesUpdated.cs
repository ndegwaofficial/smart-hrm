using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PnineFilesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PnineFiles_EmployeeId",
                table: "PnineFiles",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PnineFiles_Employees_EmployeeId",
                table: "PnineFiles",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PnineFiles_Employees_EmployeeId",
                table: "PnineFiles");

            migrationBuilder.DropIndex(
                name: "IX_PnineFiles_EmployeeId",
                table: "PnineFiles");
        }
    }
}
