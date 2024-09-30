using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeReactivationUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeReactivations_TerminationCategories_TerminationCategoryId",
                table: "EmployeeReactivations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeReactivations_TerminationCategoryId",
                table: "EmployeeReactivations");

            migrationBuilder.DropColumn(
                name: "TerminationCategoryId",
                table: "EmployeeReactivations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TerminationCategoryId",
                table: "EmployeeReactivations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeReactivations_TerminationCategoryId",
                table: "EmployeeReactivations",
                column: "TerminationCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeReactivations_TerminationCategories_TerminationCategoryId",
                table: "EmployeeReactivations",
                column: "TerminationCategoryId",
                principalTable: "TerminationCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
