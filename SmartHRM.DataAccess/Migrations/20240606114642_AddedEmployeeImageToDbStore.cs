using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmployeeImageToDbStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpImageUrl",
                table: "Employees",
                newName: "FileName");

            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "Employees",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Employees",
                newName: "EmpImageUrl");
        }
    }
}
