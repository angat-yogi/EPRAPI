using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LSStudentEmployeeAPI.Migrations
{
    public partial class timesAndShiftsTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    SLID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SLName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftLead", x => x.SLID);
                });

            migrationBuilder.CreateTable(
                name: "ShiftResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftResponses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimesResponses",
                columns: table => new
                {
                    TRId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesResponses", x => x.TRId);
                });

            migrationBuilder.CreateTable(
                name: "BagChecks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "Shifts",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: false),
                    position_id = table.Column<int>(type: "int", nullable: false),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    start_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    break_time = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alerted = table.Column<bool>(type: "bit", nullable: false),
                    linked_users = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shiftchain_key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    published = table.Column<bool>(type: "bit", nullable: false),
                    published_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notified_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instances = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    acknowledged = table.Column<int>(type: "int", nullable: false),
                    acknowledged_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creator_id = table.Column<int>(type: "int", nullable: false),
                    is_open = table.Column<bool>(type: "bit", nullable: false),
                    actionable = table.Column<bool>(type: "bit", nullable: false),
                    block_id = table.Column<int>(type: "int", nullable: false),
                    ShiftResponseId = table.Column<int>(type: "int", nullable: true),
                    TimesResponseTRId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Shifts_ShiftResponses_ShiftResponseId",
                        column: x => x.ShiftResponseId,
                        principalTable: "ShiftResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shifts_TimesResponses_TimesResponseTRId",
                        column: x => x.TimesResponseTRId,
                        principalTable: "TimesResponses",
                        principalColumn: "TRId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimesResponseTRId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sites_TimesResponses_TimesResponseTRId",
                        column: x => x.TimesResponseTRId,
                        principalTable: "TimesResponses",
                        principalColumn: "TRId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    creator_id = table.Column<int>(type: "int", nullable: false),
                    position_id = table.Column<int>(type: "int", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: false),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    shift_id = table.Column<long>(type: "bigint", nullable: false),
                    start_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    length = table.Column<double>(type: "float", nullable: false),
                    hourly_rate = table.Column<double>(type: "float", nullable: false),
                    alert_type = table.Column<int>(type: "int", nullable: false),
                    is_approved = table.Column<bool>(type: "bit", nullable: false),
                    modified_by = table.Column<int>(type: "int", nullable: false),
                    sync_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sync_hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    split_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    break_hours = table.Column<int>(type: "int", nullable: false),
                    is_alerted = table.Column<bool>(type: "bit", nullable: false),
                    TimesResponseTRId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.id);
                    table.ForeignKey(
                        name: "FK_Times_TimesResponses_TimesResponseTRId",
                        column: x => x.TimesResponseTRId,
                        principalTable: "TimesResponses",
                        principalColumn: "TRId",
                        onDelete: ReferentialAction.Restrict);
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
                    ShiftResponseId = table.Column<int>(type: "int", nullable: true),
                    TimesResponseTRId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_ShiftResponses_ShiftResponseId",
                        column: x => x.ShiftResponseId,
                        principalTable: "ShiftResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_TimesResponses_TimesResponseTRId",
                        column: x => x.TimesResponseTRId,
                        principalTable: "TimesResponses",
                        principalColumn: "TRId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BagChecks_EmployeeId",
                table: "BagChecks",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_ShiftResponseId",
                table: "Shifts",
                column: "ShiftResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_TimesResponseTRId",
                table: "Shifts",
                column: "TimesResponseTRId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_TimesResponseTRId",
                table: "Sites",
                column: "TimesResponseTRId");

            migrationBuilder.CreateIndex(
                name: "IX_TechCheck_EmployeeId",
                table: "TechCheck",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Times_TimesResponseTRId",
                table: "Times",
                column: "TimesResponseTRId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ShiftResponseId",
                table: "Users",
                column: "ShiftResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TimesResponseTRId",
                table: "Users",
                column: "TimesResponseTRId");
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
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "TechCheck");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ShiftResponses");

            migrationBuilder.DropTable(
                name: "TimesResponses");
        }
    }
}
