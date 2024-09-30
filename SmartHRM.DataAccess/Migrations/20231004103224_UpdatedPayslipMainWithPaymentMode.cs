using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPayslipMainWithPaymentMode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModeOfPayment",
                table: "PayslipMains",
                newName: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipMains_PaymentModeId",
                table: "PayslipMains",
                column: "PaymentModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayslipMains_PaymentModes_PaymentModeId",
                table: "PayslipMains",
                column: "PaymentModeId",
                principalTable: "PaymentModes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayslipMains_PaymentModes_PaymentModeId",
                table: "PayslipMains");

            migrationBuilder.DropIndex(
                name: "IX_PayslipMains_PaymentModeId",
                table: "PayslipMains");

            migrationBuilder.RenameColumn(
                name: "PaymentModeId",
                table: "PayslipMains",
                newName: "ModeOfPayment");
        }
    }
}
