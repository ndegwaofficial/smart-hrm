using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PaymentModeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentModeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PaymentModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentModeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentModes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PaymentModeId",
                table: "Employees",
                column: "PaymentModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PaymentModes_PaymentModeId",
                table: "Employees",
                column: "PaymentModeId",
                principalTable: "PaymentModes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PaymentModes_PaymentModeId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "PaymentModes");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PaymentModeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PaymentModeId",
                table: "Employees");
        }
    }
}
