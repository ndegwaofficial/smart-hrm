using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeyToTerminationOverload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerminations_ApprovedById",
                table: "EmployeeTerminations",
                column: "ApprovedById");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_ApprovedById",
                table: "EmployeeTerminations",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_ApprovedById",
                table: "EmployeeTerminations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTerminations_ApprovedById",
                table: "EmployeeTerminations");
        }
    }
}
