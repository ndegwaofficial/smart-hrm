using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTerminated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Termindated",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Termindated",
                table: "Employees");
        }
    }
}
