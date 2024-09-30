using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MadeRelateableUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "InitiatedBy",
                table: "EmployeeTerminations");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "EmployeeTerminations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedById",
                table: "EmployeeTerminations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InitiatedById",
                table: "EmployeeTerminations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerminations_ApplicationUserId",
                table: "EmployeeTerminations",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_ApplicationUserId",
                table: "EmployeeTerminations",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_ApplicationUserId",
                table: "EmployeeTerminations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTerminations_ApplicationUserId",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "ApprovedById",
                table: "EmployeeTerminations");

            migrationBuilder.DropColumn(
                name: "InitiatedById",
                table: "EmployeeTerminations");

            migrationBuilder.AddColumn<string>(
                name: "ApprovedBy",
                table: "EmployeeTerminations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InitiatedBy",
                table: "EmployeeTerminations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
