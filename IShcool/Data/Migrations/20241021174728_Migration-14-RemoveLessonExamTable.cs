using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration14RemoveLessonExamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonsExam");

            migrationBuilder.DropTable(
                name: "LExamResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LessonsExam",
                columns: table => new
                {
                    Vedio_Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quest = table.Column<string>(type: "nvarchar(185)", maxLength: 185, nullable: false),
                    Correct_Answer = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Frist_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Frist_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quest_Type = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Second_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Second_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Third_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Third_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonsExam", x => new { x.Vedio_Url, x.Quest });
                });

            migrationBuilder.CreateTable(
                name: "LExamResults",
                columns: table => new
                {
                    Vedio_Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Correct_Answers_No = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Time = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LExamResults", x => new { x.Vedio_Url, x.StudentId });
                    table.ForeignKey(
                        name: "FK_LExamResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LExamResults_StudentId",
                table: "LExamResults",
                column: "StudentId");
        }
    }
}
