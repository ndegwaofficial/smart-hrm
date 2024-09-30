using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedIdsToString2 : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "InitiatedById",
                table: "EmployeeTerminations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedById",
                table: "EmployeeTerminations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InitiatedById",
                table: "EmployeeTerminations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedById",
                table: "EmployeeTerminations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
