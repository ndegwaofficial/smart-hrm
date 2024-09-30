using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenamedIdentityTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeReactivations_AspNetUsers_ApprovedById",
                table: "EmployeeReactivations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeReactivations_AspNetUsers_InitiatedById",
                table: "EmployeeReactivations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_ApprovedById",
                table: "EmployeeTerminations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_InitiatedById",
                table: "EmployeeTerminations");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                newName: "TransferredNightshiftHours",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transactions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                newName: "TonnagePosts",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                newName: "TimeAttendanceRaws",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                newName: "TerminationCategories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShoppingCarts",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                newName: "PnineFiles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                newName: "PeriodicalPartProcesss",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                newName: "periodHistories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                newName: "PaySlipTotalEarnings",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                newName: "PayslipTotalDeductions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                newName: "PaySlipPensions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                newName: "PayslipPayments",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                newName: "PayslipPayes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                newName: "Payslipnoncashes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                newName: "PayslipNhifReliefs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                newName: "PayslipMains",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                newName: "PayslipLoans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                newName: "PayslipInsuranceReliefs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                newName: "PayslipHousingLevyReliefs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                newName: "PaySlipHousingLevies",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                newName: "PayslipDeductions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                newName: "PayrollprocessStages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                newName: "PayrollMainReports",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                newName: "PayrollCodes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                newName: "PaymentModes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Payes",
                newName: "Payes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                newName: "OvertimeAbsentTransactions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                newName: "OtherPayments",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                newName: "OrphanedTonnageDatas",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                newName: "OrphanedNightshiftDatas",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                newName: "OrderHeaders",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetails",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                newName: "Nssfs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                newName: "NightshiftHoursPostings",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                newName: "Nhifs",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                newName: "MonthlyTransferInfos",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                newName: "Monthlybonuses",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                newName: "LoanSchedules",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "Loans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                newName: "GeneralParameters",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Genders",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                newName: "EmpResumes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                newName: "EmpPinImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                newName: "EmpNssfImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                newName: "EmpNhifImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                newName: "EmployeeTerminations",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                newName: "EmployeesHoursDays",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                newName: "EmployeeReactivations",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                newName: "EmployeeGrades",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                newName: "EmployeeCategories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                newName: "EmployeeAnnualLeaves",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                newName: "EmpIdImages",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Divisions",
                newName: "Divisions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Departments",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                newName: "CurrentPeriods",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currencies",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                newName: "CPnineFiles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                newName: "CPayslipMains",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                newName: "CPayslipLoans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                newName: "CPayrollMainReports",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                newName: "CoverTypes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                newName: "ContractTypes",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CompSections",
                newName: "CompSections",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                newName: "CompanyBranches",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Companies",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                newName: "CLoanSchedules",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CLoans",
                newName: "CLoans",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                newName: "Bonuses",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Banks",
                newName: "Banks",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                newName: "BankBranches",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                newName: "AbsentTransactions",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "User",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Role",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims",
                newSchema: "Identity");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CompanyId",
                schema: "Identity",
                table: "User",
                newName: "IX_User_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Identity",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Identity",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Identity",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                schema: "Identity",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "Identity",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                schema: "Identity",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                schema: "Identity",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                schema: "Identity",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Identity",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeReactivations_User_ApprovedById",
                schema: "Identity",
                table: "EmployeeReactivations",
                column: "ApprovedById",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeReactivations_User_InitiatedById",
                schema: "Identity",
                table: "EmployeeReactivations",
                column: "InitiatedById",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTerminations_User_ApprovedById",
                schema: "Identity",
                table: "EmployeeTerminations",
                column: "ApprovedById",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTerminations_User_InitiatedById",
                schema: "Identity",
                table: "EmployeeTerminations",
                column: "InitiatedById",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_User_ApplicationUserId",
                schema: "Identity",
                table: "OrderHeaders",
                column: "ApplicationUserId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Role_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "Identity",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_User_ApplicationUserId",
                schema: "Identity",
                table: "ShoppingCarts",
                column: "ApplicationUserId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Companies_CompanyId",
                schema: "Identity",
                table: "User",
                column: "CompanyId",
                principalSchema: "Identity",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_User_UserId",
                schema: "Identity",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_User_UserId",
                schema: "Identity",
                table: "UserLogins",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Identity",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "Identity",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_UserId",
                schema: "Identity",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_User_UserId",
                schema: "Identity",
                table: "UserTokens",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeReactivations_User_ApprovedById",
                schema: "Identity",
                table: "EmployeeReactivations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeReactivations_User_InitiatedById",
                schema: "Identity",
                table: "EmployeeReactivations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTerminations_User_ApprovedById",
                schema: "Identity",
                table: "EmployeeTerminations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTerminations_User_InitiatedById",
                schema: "Identity",
                table: "EmployeeTerminations");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_User_ApplicationUserId",
                schema: "Identity",
                table: "OrderHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Role_RoleId",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_User_ApplicationUserId",
                schema: "Identity",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Companies_CompanyId",
                schema: "Identity",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_User_UserId",
                schema: "Identity",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_User_UserId",
                schema: "Identity",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Identity",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_UserId",
                schema: "Identity",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_User_UserId",
                schema: "Identity",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                schema: "Identity",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Identity",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                schema: "Identity",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                schema: "Identity",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "Identity",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                schema: "Identity",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "TransferredNightshiftHours",
                schema: "Identity",
                newName: "TransferredNightshiftHours");

            migrationBuilder.RenameTable(
                name: "Transactions",
                schema: "Identity",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "TonnagePosts",
                schema: "Identity",
                newName: "TonnagePosts");

            migrationBuilder.RenameTable(
                name: "TimeAttendanceRaws",
                schema: "Identity",
                newName: "TimeAttendanceRaws");

            migrationBuilder.RenameTable(
                name: "TerminationCategories",
                schema: "Identity",
                newName: "TerminationCategories");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                schema: "Identity",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Identity",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PnineFiles",
                schema: "Identity",
                newName: "PnineFiles");

            migrationBuilder.RenameTable(
                name: "PeriodicalPartProcesss",
                schema: "Identity",
                newName: "PeriodicalPartProcesss");

            migrationBuilder.RenameTable(
                name: "periodHistories",
                schema: "Identity",
                newName: "periodHistories");

            migrationBuilder.RenameTable(
                name: "PaySlipTotalEarnings",
                schema: "Identity",
                newName: "PaySlipTotalEarnings");

            migrationBuilder.RenameTable(
                name: "PayslipTotalDeductions",
                schema: "Identity",
                newName: "PayslipTotalDeductions");

            migrationBuilder.RenameTable(
                name: "PaySlipPensions",
                schema: "Identity",
                newName: "PaySlipPensions");

            migrationBuilder.RenameTable(
                name: "PayslipPayments",
                schema: "Identity",
                newName: "PayslipPayments");

            migrationBuilder.RenameTable(
                name: "PayslipPayes",
                schema: "Identity",
                newName: "PayslipPayes");

            migrationBuilder.RenameTable(
                name: "Payslipnoncashes",
                schema: "Identity",
                newName: "Payslipnoncashes");

            migrationBuilder.RenameTable(
                name: "PayslipNhifReliefs",
                schema: "Identity",
                newName: "PayslipNhifReliefs");

            migrationBuilder.RenameTable(
                name: "PayslipMains",
                schema: "Identity",
                newName: "PayslipMains");

            migrationBuilder.RenameTable(
                name: "PayslipLoans",
                schema: "Identity",
                newName: "PayslipLoans");

            migrationBuilder.RenameTable(
                name: "PayslipInsuranceReliefs",
                schema: "Identity",
                newName: "PayslipInsuranceReliefs");

            migrationBuilder.RenameTable(
                name: "PayslipHousingLevyReliefs",
                schema: "Identity",
                newName: "PayslipHousingLevyReliefs");

            migrationBuilder.RenameTable(
                name: "PaySlipHousingLevies",
                schema: "Identity",
                newName: "PaySlipHousingLevies");

            migrationBuilder.RenameTable(
                name: "PayslipDeductions",
                schema: "Identity",
                newName: "PayslipDeductions");

            migrationBuilder.RenameTable(
                name: "PayrollprocessStages",
                schema: "Identity",
                newName: "PayrollprocessStages");

            migrationBuilder.RenameTable(
                name: "PayrollMainReports",
                schema: "Identity",
                newName: "PayrollMainReports");

            migrationBuilder.RenameTable(
                name: "PayrollCodes",
                schema: "Identity",
                newName: "PayrollCodes");

            migrationBuilder.RenameTable(
                name: "PaymentModes",
                schema: "Identity",
                newName: "PaymentModes");

            migrationBuilder.RenameTable(
                name: "Payes",
                schema: "Identity",
                newName: "Payes");

            migrationBuilder.RenameTable(
                name: "OvertimeAbsentTransactions",
                schema: "Identity",
                newName: "OvertimeAbsentTransactions");

            migrationBuilder.RenameTable(
                name: "OtherPayments",
                schema: "Identity",
                newName: "OtherPayments");

            migrationBuilder.RenameTable(
                name: "OrphanedTonnageDatas",
                schema: "Identity",
                newName: "OrphanedTonnageDatas");

            migrationBuilder.RenameTable(
                name: "OrphanedNightshiftDatas",
                schema: "Identity",
                newName: "OrphanedNightshiftDatas");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                schema: "Identity",
                newName: "OrderHeaders");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                schema: "Identity",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Nssfs",
                schema: "Identity",
                newName: "Nssfs");

            migrationBuilder.RenameTable(
                name: "NightshiftHoursPostings",
                schema: "Identity",
                newName: "NightshiftHoursPostings");

            migrationBuilder.RenameTable(
                name: "Nhifs",
                schema: "Identity",
                newName: "Nhifs");

            migrationBuilder.RenameTable(
                name: "MonthlyTransferInfos",
                schema: "Identity",
                newName: "MonthlyTransferInfos");

            migrationBuilder.RenameTable(
                name: "Monthlybonuses",
                schema: "Identity",
                newName: "Monthlybonuses");

            migrationBuilder.RenameTable(
                name: "LoanSchedules",
                schema: "Identity",
                newName: "LoanSchedules");

            migrationBuilder.RenameTable(
                name: "Loans",
                schema: "Identity",
                newName: "Loans");

            migrationBuilder.RenameTable(
                name: "GeneralParameters",
                schema: "Identity",
                newName: "GeneralParameters");

            migrationBuilder.RenameTable(
                name: "Genders",
                schema: "Identity",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "EmpResumes",
                schema: "Identity",
                newName: "EmpResumes");

            migrationBuilder.RenameTable(
                name: "EmpPinImages",
                schema: "Identity",
                newName: "EmpPinImages");

            migrationBuilder.RenameTable(
                name: "EmpNssfImages",
                schema: "Identity",
                newName: "EmpNssfImages");

            migrationBuilder.RenameTable(
                name: "EmpNhifImages",
                schema: "Identity",
                newName: "EmpNhifImages");

            migrationBuilder.RenameTable(
                name: "EmployeeTerminations",
                schema: "Identity",
                newName: "EmployeeTerminations");

            migrationBuilder.RenameTable(
                name: "EmployeesHoursDays",
                schema: "Identity",
                newName: "EmployeesHoursDays");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "Identity",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "EmployeeReactivations",
                schema: "Identity",
                newName: "EmployeeReactivations");

            migrationBuilder.RenameTable(
                name: "EmployeeGrades",
                schema: "Identity",
                newName: "EmployeeGrades");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                schema: "Identity",
                newName: "EmployeeCategories");

            migrationBuilder.RenameTable(
                name: "EmployeeAnnualLeaves",
                schema: "Identity",
                newName: "EmployeeAnnualLeaves");

            migrationBuilder.RenameTable(
                name: "EmpIdImages",
                schema: "Identity",
                newName: "EmpIdImages");

            migrationBuilder.RenameTable(
                name: "Divisions",
                schema: "Identity",
                newName: "Divisions");

            migrationBuilder.RenameTable(
                name: "Departments",
                schema: "Identity",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "CurrentPeriods",
                schema: "Identity",
                newName: "CurrentPeriods");

            migrationBuilder.RenameTable(
                name: "Currencies",
                schema: "Identity",
                newName: "Currencies");

            migrationBuilder.RenameTable(
                name: "CPnineFiles",
                schema: "Identity",
                newName: "CPnineFiles");

            migrationBuilder.RenameTable(
                name: "CPayslipMains",
                schema: "Identity",
                newName: "CPayslipMains");

            migrationBuilder.RenameTable(
                name: "CPayslipLoans",
                schema: "Identity",
                newName: "CPayslipLoans");

            migrationBuilder.RenameTable(
                name: "CPayrollMainReports",
                schema: "Identity",
                newName: "CPayrollMainReports");

            migrationBuilder.RenameTable(
                name: "CoverTypes",
                schema: "Identity",
                newName: "CoverTypes");

            migrationBuilder.RenameTable(
                name: "ContractTypes",
                schema: "Identity",
                newName: "ContractTypes");

            migrationBuilder.RenameTable(
                name: "CompSections",
                schema: "Identity",
                newName: "CompSections");

            migrationBuilder.RenameTable(
                name: "CompanyBranches",
                schema: "Identity",
                newName: "CompanyBranches");

            migrationBuilder.RenameTable(
                name: "Companies",
                schema: "Identity",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "CLoanSchedules",
                schema: "Identity",
                newName: "CLoanSchedules");

            migrationBuilder.RenameTable(
                name: "CLoans",
                schema: "Identity",
                newName: "CLoans");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "Identity",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                schema: "Identity",
                newName: "Bonuses");

            migrationBuilder.RenameTable(
                name: "Banks",
                schema: "Identity",
                newName: "Banks");

            migrationBuilder.RenameTable(
                name: "BankBranches",
                schema: "Identity",
                newName: "BankBranches");

            migrationBuilder.RenameTable(
                name: "AbsentTransactions",
                schema: "Identity",
                newName: "AbsentTransactions");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Identity",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Identity",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Identity",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Identity",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Identity",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Identity",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Identity",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_CompanyId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeReactivations_AspNetUsers_ApprovedById",
                table: "EmployeeReactivations",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeReactivations_AspNetUsers_InitiatedById",
                table: "EmployeeReactivations",
                column: "InitiatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_ApprovedById",
                table: "EmployeeTerminations",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTerminations_AspNetUsers_InitiatedById",
                table: "EmployeeTerminations",
                column: "InitiatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
                /*onDelete: ReferentialAction.Cascade*/);
        }
    }
}
