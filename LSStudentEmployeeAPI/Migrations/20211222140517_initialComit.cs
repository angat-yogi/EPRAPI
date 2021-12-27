using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LSStudentEmployeeAPI.Migrations
{
    public partial class initialComit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraduateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "FTEReviews",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EvaluatingPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluatingFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobKnowledge = table.Column<double>(type: "float", nullable: false),
                    QualityOfWork = table.Column<double>(type: "float", nullable: false),
                    Communication = table.Column<double>(type: "float", nullable: false),
                    Initiative = table.Column<double>(type: "float", nullable: false),
                    Reliability = table.Column<double>(type: "float", nullable: false),
                    ConstructiveFeedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositiveFeedBack = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTEReviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelfEvals",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EvaluatingPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobKnowledge = table.Column<double>(type: "float", nullable: false),
                    QualityOfWork = table.Column<double>(type: "float", nullable: false),
                    Communication = table.Column<double>(type: "float", nullable: false),
                    Initiative = table.Column<double>(type: "float", nullable: false),
                    Reliability = table.Column<double>(type: "float", nullable: false),
                    giveFeedback = table.Column<bool>(type: "bit", nullable: true),
                    FeedbackFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedBack = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfEvals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShiftLead",
                columns: table => new
                {
                    SLID = table.Column<int>(type: "int", nullable: false),
                    SLName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftLead", x => x.SLID);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "BagChecks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Bag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagChecks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BagChecks_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechCheck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechCheck_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    login_id = table.Column<int>(type: "int", nullable: false),
                    timezone_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false),
                    is_payroll = table.Column<bool>(type: "bit", nullable: false),
                    is_trusted = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    activated = table.Column<bool>(type: "bit", nullable: false),
                    is_hidden = table.Column<bool>(type: "bit", nullable: false),
                    uuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_private = table.Column<bool>(type: "bit", nullable: false),
                    hours_preferred = table.Column<int>(type: "int", nullable: false),
                    hours_max = table.Column<int>(type: "int", nullable: false),
                    hourly_rate = table.Column<double>(type: "float", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "ShiftId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BagChecks_EmployeeId",
                table: "BagChecks",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TechCheck_EmployeeId",
                table: "TechCheck",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ShiftId",
                table: "Users",
                column: "ShiftId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BagChecks");

            migrationBuilder.DropTable(
                name: "FTEReviews");

            migrationBuilder.DropTable(
                name: "SelfEvals");

            migrationBuilder.DropTable(
                name: "ShiftLead");

            migrationBuilder.DropTable(
                name: "TechCheck");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Shifts");
        }
    }
}
