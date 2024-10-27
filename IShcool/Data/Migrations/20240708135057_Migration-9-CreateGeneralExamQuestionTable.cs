using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration9CreateGeneralExamQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralExamQuestions",
                columns: table => new
                {
                    ExamTitle = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Academy_Year = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Quest = table.Column<string>(type: "nvarchar(185)", maxLength: 185, nullable: false),
                    Quest_Type = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Frist_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Second_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Third_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Frist_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Second_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Third_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correct_Answer = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Time = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralExamQuestions", x => new { x.TeacherId, x.ExamTitle, x.Academy_Year, x.Quest });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralExamQuestions");
        }
    }
}
