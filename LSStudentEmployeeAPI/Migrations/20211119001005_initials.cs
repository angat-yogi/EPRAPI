using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LSStudentEmployeeAPI.Migrations
{
    public partial class initials : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "FTEReviews");

            migrationBuilder.DropTable(
                name: "SelfEvals");
        }
    }
}
