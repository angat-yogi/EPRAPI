using Microsoft.EntityFrameworkCore.Migrations;

namespace LSStudentEmployeeAPI.Migrations
{
    public partial class addUserTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    hourly_rate = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_Users_ShiftId",
                table: "Users",
                column: "ShiftId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Shifts");
        }
    }
}
