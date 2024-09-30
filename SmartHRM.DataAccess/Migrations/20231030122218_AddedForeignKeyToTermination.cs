using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeyToTermination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerminations_InitiatedById",
                table: "EmployeeTerminations",
                column: "InitiatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_InitiatedById",
                table: "EmployeeTerminations",
                column: "InitiatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_InitiatedById",
                table: "EmployeeTerminations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTerminations_InitiatedById",
                table: "EmployeeTerminations");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "EmployeeTerminations",
                type: "nvarchar(450)",
                nullable: true);

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
    }
}
