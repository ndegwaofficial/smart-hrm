using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoverTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Default = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentMonth = table.Column<int>(type: "int", nullable: false),
                    PeriodWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LowerAmount = table.Column<double>(type: "float", nullable: false),
                    UpperAmount = table.Column<double>(type: "float", nullable: false),
                    DailyRate = table.Column<double>(type: "float", nullable: false),
                    HourlyRate = table.Column<double>(type: "float", nullable: false),
                    NightOutRate = table.Column<double>(type: "float", nullable: false),
                    PerDiemRate = table.Column<double>(type: "float", nullable: false),
                    TonnageRate = table.Column<double>(type: "float", nullable: false),
                    opthourly = table.Column<bool>(type: "bit", nullable: false),
                    optdaily = table.Column<bool>(type: "bit", nullable: false),
                    opttonnage = table.Column<bool>(type: "bit", nullable: false),
                    multipleprocess = table.Column<bool>(type: "bit", nullable: false),
                    permanentemp = table.Column<bool>(type: "bit", nullable: false),
                    maxtonne = table.Column<double>(type: "float", nullable: false),
                    bonusrate = table.Column<double>(type: "float", nullable: false),
                    abovetonne = table.Column<double>(type: "float", nullable: false),
                    payfortonnes = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsReliefPercent = table.Column<int>(type: "int", nullable: false),
                    InsMaximumMonthly = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PensionEmployeePercent = table.Column<int>(type: "int", nullable: false),
                    PensionEmployerPercent = table.Column<int>(type: "int", nullable: false),
                    BasePensionOnTaxablePay = table.Column<bool>(type: "bit", nullable: false),
                    BaseonTaxablePay = table.Column<bool>(type: "bit", nullable: false),
                    MaximumPension = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsurancePolicyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NSSFEmployer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NSSFmaximum = table.Column<decimal>(name: "NSSF_maximum", type: "decimal(18,2)", nullable: false),
                    NSSFEmployee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpCodeSecOneLength = table.Column<int>(type: "int", nullable: false),
                    EmpCodeSecTwoLength = table.Column<int>(type: "int", nullable: false),
                    EmpCodeSecOneString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpCodeSeparator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empcodeMainString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecimalRounding = table.Column<int>(type: "int", nullable: false),
                    HousingPer = table.Column<int>(type: "int", nullable: false),
                    CalculateHousing = table.Column<bool>(type: "bit", nullable: false),
                    workingdays = table.Column<double>(type: "float", nullable: false),
                    KUSPAW = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    driverSavings = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    nightShiftRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    loaderSaving = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cotuPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    newrules = table.Column<bool>(type: "bit", nullable: false),
                    holidayTonnage = table.Column<int>(type: "int", nullable: false),
                    HousingLevy = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nhifs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromamnt = table.Column<double>(type: "float", nullable: false),
                    uptoamnt = table.Column<double>(type: "float", nullable: false),
                    Nhifamount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhifs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nssfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nationalavgearning = table.Column<double>(name: "national_avg_earning", type: "float", nullable: false),
                    upperearninglimitper = table.Column<double>(name: "upper_earning_limit_per", type: "float", nullable: false),
                    upperearninglimitamnt = table.Column<double>(name: "upper_earning_limit_amnt", type: "float", nullable: false),
                    lowerearninglimitamnt = table.Column<double>(name: "lower_earning_limit_amnt", type: "float", nullable: false),
                    employeepercent = table.Column<double>(name: "employee_percent", type: "float", nullable: false),
                    employerpercent = table.Column<double>(name: "employer_percent", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nssfs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LowerLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpperLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayrollCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Limit = table.Column<double>(type: "float", nullable: false),
                    RoundIn = table.Column<double>(type: "float", nullable: false),
                    Taxable = table.Column<bool>(type: "bit", nullable: false),
                    Loan = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<bool>(type: "bit", nullable: false),
                    NonTaxable = table.Column<bool>(type: "bit", nullable: false),
                    Variable = table.Column<bool>(type: "bit", nullable: false),
                    Payment = table.Column<bool>(type: "bit", nullable: false),
                    Deduction = table.Column<bool>(type: "bit", nullable: false),
                    Fixed = table.Column<bool>(type: "bit", nullable: false),
                    Statement = table.Column<bool>(type: "bit", nullable: false),
                    Insurance = table.Column<bool>(type: "bit", nullable: false),
                    Recurring = table.Column<bool>(type: "bit", nullable: false),
                    NonCashBenefit = table.Column<bool>(type: "bit", nullable: false),
                    Nssfinc = table.Column<bool>(name: "Nssf_inc", type: "bit", nullable: false),
                    Nhifinc = table.Column<bool>(name: "Nhif_inc", type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayrollprocessStages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Final = table.Column<bool>(type: "bit", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollprocessStages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeAttendanceRaws",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresentDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AbsentDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpNationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posted = table.Column<bool>(type: "bit", nullable: false),
                    Synid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeAttendanceRaws", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankBranches_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NHIF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSSF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyBranches_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CoverTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CoverTypes_CoverTypeId",
                        column: x => x.CoverTypeId,
                        principalTable: "CoverTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyBranchId = table.Column<int>(type: "int", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<double>(type: "float", nullable: false),
                    Savings = table.Column<double>(type: "float", nullable: false),
                    BonusNoOfTrips = table.Column<int>(type: "int", nullable: false),
                    BonusTonnageMin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_CompanyBranches_CompanyBranchId",
                        column: x => x.CompanyBranchId,
                        principalTable: "CompanyBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    CompanyBranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_CompanyBranches_CompanyBranchId",
                        column: x => x.CompanyBranchId,
                        principalTable: "CompanyBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Departments_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CompSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompSections_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompSections_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    EmpImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KRAPin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NHIFNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSSFNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    ContractTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeCategoryId = table.Column<int>(type: "int", nullable: false),
                    EmployeeGradeId = table.Column<int>(type: "int", nullable: false),
                    CompanyBranchId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    DateEmployed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLeft = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicPay = table.Column<double>(type: "float", nullable: false),
                    Pensionable = table.Column<bool>(type: "bit", nullable: false),
                    BankID = table.Column<int>(type: "int", nullable: false),
                    BankBranchID = table.Column<int>(type: "int", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExemptPAYE = table.Column<bool>(type: "bit", nullable: false),
                    ExemptNHIF = table.Column<bool>(type: "bit", nullable: false),
                    ExemptRelief = table.Column<bool>(type: "bit", nullable: false),
                    ExemptNSSF = table.Column<bool>(type: "bit", nullable: false),
                    DeductPAYE = table.Column<bool>(type: "bit", nullable: false),
                    DeductNHIF = table.Column<bool>(type: "bit", nullable: false),
                    DeductNSSF = table.Column<bool>(type: "bit", nullable: false),
                    OverwritePAYE = table.Column<bool>(type: "bit", nullable: false),
                    OverwriteNHIF = table.Column<bool>(type: "bit", nullable: false),
                    OverwriteNSSF = table.Column<bool>(type: "bit", nullable: false),
                    OverwritePension = table.Column<bool>(type: "bit", nullable: false),
                    PAYEAmount = table.Column<double>(type: "float", nullable: false),
                    NHIFAmount = table.Column<double>(type: "float", nullable: false),
                    NSSFAmount = table.Column<double>(type: "float", nullable: false),
                    PensionAmount = table.Column<double>(type: "float", nullable: false),
                    HasHouseAllowance = table.Column<bool>(type: "bit", nullable: false),
                    HouseAllowance = table.Column<double>(type: "float", nullable: false),
                    savings = table.Column<bool>(type: "bit", nullable: false),
                    CotuMember = table.Column<bool>(type: "bit", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Unavilable = table.Column<bool>(type: "bit", nullable: false),
                    Away = table.Column<bool>(type: "bit", nullable: false),
                    OnLeave = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_BankBranches_BankBranchID",
                        column: x => x.BankBranchID,
                        principalTable: "BankBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Employees_Banks_BankID",
                        column: x => x.BankID,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Employees_CompSections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "CompSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Employees_CompanyBranches_CompanyBranchId",
                        column: x => x.CompanyBranchId,
                        principalTable: "CompanyBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Employees_ContractTypes_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Employees_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeCategories_EmployeeCategoryId",
                        column: x => x.EmployeeCategoryId,
                        principalTable: "EmployeeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeGrades_EmployeeGradeId",
                        column: x => x.EmployeeGradeId,
                        principalTable: "EmployeeGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesHoursDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cmonth = table.Column<int>(type: "int", nullable: false),
                    Cyear = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Hoursdays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Refid = table.Column<int>(name: "Ref_id", type: "int", nullable: true),
                    Refdate = table.Column<DateTime>(name: "Ref_date", type: "datetime2", nullable: true),
                    Tonnage = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesHoursDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesHoursDays_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    LoanDesc = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LoanTransDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanStartPeriod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LoanEndPeriod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NoInterest = table.Column<bool>(type: "bit", nullable: false),
                    Reducing = table.Column<bool>(type: "bit", nullable: false),
                    Fixed = table.Column<bool>(type: "bit", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlyRecoveryAmnt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RND = table.Column<int>(type: "int", nullable: false),
                    NumberOfPeriods = table.Column<int>(type: "int", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UseMonthlyRecov = table.Column<bool>(type: "bit", nullable: false),
                    Cleared = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OvertimeAbsentTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    Pyear = table.Column<int>(type: "int", nullable: false),
                    HoursValue = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    opt15 = table.Column<bool>(type: "bit", nullable: false),
                    opt2 = table.Column<bool>(type: "bit", nullable: false),
                    stage = table.Column<int>(type: "int", nullable: false),
                    Transdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OvertimeAbsentTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OvertimeAbsentTransactions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipDeductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    DeductionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeductionAmnt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Insurance = table.Column<bool>(type: "bit", nullable: false),
                    BalanceDed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Employer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Nodelete = table.Column<bool>(type: "bit", nullable: false),
                    standardamnt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    maximumamnt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RateValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipDeductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipDeductions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayslipDeductions_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaySlipHousingLevies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    PayYear = table.Column<int>(type: "int", nullable: false),
                    EmployeeHousingLevy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployerHousingLevy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxablePortion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PortionExempted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeHLevyPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployerHLevyPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaySlipHousingLevies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaySlipHousingLevies_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipInsuranceReliefs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    PayYear = table.Column<int>(type: "int", nullable: false),
                    ReliefAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PortionToTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceReliefName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipInsuranceReliefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipInsuranceReliefs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipLoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    LoanName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoantMonthlyPrincipal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Periodx = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LoanNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipLoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipLoans_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayslipLoans_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipMains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhifNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NssfNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PersonalRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModeOfPayment = table.Column<int>(type: "int", nullable: false),
                    BankID = table.Column<int>(type: "int", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankBranchID = table.Column<int>(type: "int", nullable: false),
                    BankBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompBranch = table.Column<int>(type: "int", nullable: false),
                    BasicBalanceToDate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    HoursDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    HouseAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateEmployed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Savings = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipMains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipMains_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipNhifReliefs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    PayYear = table.Column<int>(type: "int", nullable: false),
                    ReliefAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PortionToTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PortionToExempt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NhifReliefName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipNhifReliefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipNhifReliefs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payslipnoncashes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    TransYear = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxable = table.Column<bool>(type: "bit", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BalancePay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stage = table.Column<int>(type: "int", nullable: false),
                    datefrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payslipnoncashes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payslipnoncashes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payslipnoncashes_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipPayes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    RawPaye = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxCharged = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxablePay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceRelief = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipPayes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipPayes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TransPeriod = table.Column<int>(type: "int", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxable = table.Column<bool>(type: "bit", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalancePay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalcValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RateValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipPayments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayslipPayments_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaySlipPensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayYear = table.Column<int>(type: "int", nullable: false),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    EmployeePension = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployerPension = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxablePortion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PortionExempted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeePensionPercent = table.Column<float>(type: "real", nullable: false),
                    EmployerPensionPercent = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaySlipPensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaySlipPensions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipTotalDeductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    PayYear = table.Column<int>(type: "int", nullable: false),
                    TotalDeductions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipTotalDeductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipTotalDeductions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaySlipTotalEarnings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    PayYear = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TotalEarning = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaySlipTotalEarnings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaySlipTotalEarnings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeriodicalPartProcesss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProcessYear = table.Column<int>(type: "int", nullable: false),
                    ProcessMonth = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountCalc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodicalPartProcesss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodicalPartProcesss_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentMonth = table.Column<int>(type: "int", nullable: false),
                    CurrentYear = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayrollCodeId = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    EffectiveFromPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransYear = table.Column<int>(type: "int", nullable: false),
                    TransFixed = table.Column<int>(type: "int", nullable: false),
                    TransRef = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TransAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Stopped = table.Column<bool>(type: "bit", nullable: false),
                    stage = table.Column<int>(type: "int", nullable: false),
                    rejected = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_PayrollCodes_PayrollCodeId",
                        column: x => x.PayrollCodeId,
                        principalTable: "PayrollCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<int>(type: "int", nullable: false),
                    PaymentNumber = table.Column<int>(type: "int", nullable: false),
                    Icharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceBF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlyRecov = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CummulativeInterest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanSchedules_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BankBranches_BankId",
                table: "BankBranches",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranches_CompanyId",
                table: "CompanyBranches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompSections_DepartmentId",
                table: "CompSections",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompSections_DivisionId",
                table: "CompSections",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyBranchId",
                table: "Departments",
                column: "CompanyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DivisionId",
                table: "Departments",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_CompanyBranchId",
                table: "Divisions",
                column: "CompanyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BankBranchID",
                table: "Employees",
                column: "BankBranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BankID",
                table: "Employees",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyBranchId",
                table: "Employees",
                column: "CompanyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ContractTypeId",
                table: "Employees",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CurrencyId",
                table: "Employees",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DivisionId",
                table: "Employees",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeCategoryId",
                table: "Employees",
                column: "EmployeeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeGradeId",
                table: "Employees",
                column: "EmployeeGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SectionId",
                table: "Employees",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesHoursDays_EmployeeId",
                table: "EmployeesHoursDays",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_EmployeeId",
                table: "Loans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PayrollCodeId",
                table: "Loans",
                column: "PayrollCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanSchedules_LoanId",
                table: "LoanSchedules",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OvertimeAbsentTransactions_EmployeeId",
                table: "OvertimeAbsentTransactions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipDeductions_EmployeeId",
                table: "PayslipDeductions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipDeductions_PayrollCodeId",
                table: "PayslipDeductions",
                column: "PayrollCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaySlipHousingLevies_EmployeeId",
                table: "PaySlipHousingLevies",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipInsuranceReliefs_EmployeeId",
                table: "PayslipInsuranceReliefs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipLoans_EmployeeId",
                table: "PayslipLoans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipLoans_PayrollCodeId",
                table: "PayslipLoans",
                column: "PayrollCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipMains_EmployeeId",
                table: "PayslipMains",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipNhifReliefs_EmployeeId",
                table: "PayslipNhifReliefs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payslipnoncashes_EmployeeId",
                table: "Payslipnoncashes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payslipnoncashes_PayrollCodeId",
                table: "Payslipnoncashes",
                column: "PayrollCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipPayes_EmployeeId",
                table: "PayslipPayes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipPayments_EmployeeId",
                table: "PayslipPayments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipPayments_PayrollCodeId",
                table: "PayslipPayments",
                column: "PayrollCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaySlipPensions_EmployeeId",
                table: "PaySlipPensions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipTotalDeductions_EmployeeId",
                table: "PayslipTotalDeductions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaySlipTotalEarnings_EmployeeId",
                table: "PaySlipTotalEarnings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicalPartProcesss_EmployeeId",
                table: "PeriodicalPartProcesss",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products",
                column: "CoverTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_EmployeeId",
                table: "Transactions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PayrollCodeId",
                table: "Transactions",
                column: "PayrollCodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CurrentPeriods");

            migrationBuilder.DropTable(
                name: "EmployeesHoursDays");

            migrationBuilder.DropTable(
                name: "GeneralParameters");

            migrationBuilder.DropTable(
                name: "LoanSchedules");

            migrationBuilder.DropTable(
                name: "Nhifs");

            migrationBuilder.DropTable(
                name: "Nssfs");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OvertimeAbsentTransactions");

            migrationBuilder.DropTable(
                name: "Payes");

            migrationBuilder.DropTable(
                name: "PayrollprocessStages");

            migrationBuilder.DropTable(
                name: "PayslipDeductions");

            migrationBuilder.DropTable(
                name: "PaySlipHousingLevies");

            migrationBuilder.DropTable(
                name: "PayslipInsuranceReliefs");

            migrationBuilder.DropTable(
                name: "PayslipLoans");

            migrationBuilder.DropTable(
                name: "PayslipMains");

            migrationBuilder.DropTable(
                name: "PayslipNhifReliefs");

            migrationBuilder.DropTable(
                name: "Payslipnoncashes");

            migrationBuilder.DropTable(
                name: "PayslipPayes");

            migrationBuilder.DropTable(
                name: "PayslipPayments");

            migrationBuilder.DropTable(
                name: "PaySlipPensions");

            migrationBuilder.DropTable(
                name: "PayslipTotalDeductions");

            migrationBuilder.DropTable(
                name: "PaySlipTotalEarnings");

            migrationBuilder.DropTable(
                name: "PeriodicalPartProcesss");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "TimeAttendanceRaws");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "PayrollCodes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CoverTypes");

            migrationBuilder.DropTable(
                name: "BankBranches");

            migrationBuilder.DropTable(
                name: "CompSections");

            migrationBuilder.DropTable(
                name: "ContractTypes");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "EmployeeCategories");

            migrationBuilder.DropTable(
                name: "EmployeeGrades");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "CompanyBranches");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
