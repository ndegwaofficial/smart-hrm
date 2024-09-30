using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedAbsentDaysTransactionsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AbsentTransactions_EmployeeId",
                table: "AbsentTransactions",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbsentTransactions_Employees_EmployeeId",
                table: "AbsentTransactions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbsentTransactions_Employees_EmployeeId",
                table: "AbsentTransactions");

            migrationBuilder.DropIndex(
                name: "IX_AbsentTransactions_EmployeeId",
                table: "AbsentTransactions");
        }
    }
}
