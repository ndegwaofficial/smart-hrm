using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CasualPnineFilesCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPnineFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Yearoftax = table.Column<int>(type: "int", nullable: false),
                    Monthx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthInt = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BenefitsNonCash = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValueOfQuarters = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalGrossPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DefinedContribE1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DefinedContribE2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DefinedContribE3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OwnerOccupiedInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TheLowerOfEAddedToF = table.Column<decimal>(name: "TheLowerOf_E_Added_To_F", type: "decimal(18,2)", nullable: false),
                    ChargeablePay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxCharged = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PersonalRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PAYE = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPnineFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPnineFiles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPnineFiles_EmployeeId",
                table: "CPnineFiles",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPnineFiles");
        }
    }
}
