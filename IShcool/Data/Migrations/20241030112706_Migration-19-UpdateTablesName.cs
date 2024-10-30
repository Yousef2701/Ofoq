using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration19UpdateTablesName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralExamQuestions");

            migrationBuilder.DropTable(
                name: "GeneralExamResults");

            migrationBuilder.DropTable(
                name: "GeneralExams");

            migrationBuilder.CreateTable(
                name: "ExamQuestions",
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
                    Forth_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Frist_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Second_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Third_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Forth_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correct_Answer = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamQuestions", x => new { x.TeacherId, x.ExamTitle, x.Academy_Year, x.Quest });
                });

            migrationBuilder.CreateTable(
                name: "ExamResults",
                columns: table => new
                {
                    ExamTitle = table.Column<string>(type: "nvarchar(185)", maxLength: 185, nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Time = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Correct_Answers_No = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResults", x => new { x.TeacherId, x.ExamTitle, x.StudentId });
                    table.ForeignKey(
                        name: "FK_ExamResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamResults_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Academy_Year = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Exam_Duration = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    StartExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishExamDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => new { x.TeacherId, x.Title, x.Academy_Year });
                    table.ForeignKey(
                        name: "FK_Exams_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_StudentId",
                table: "ExamResults",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamQuestions");

            migrationBuilder.DropTable(
                name: "ExamResults");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.CreateTable(
                name: "GeneralExamQuestions",
                columns: table => new
                {
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamTitle = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Academy_Year = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Quest = table.Column<string>(type: "nvarchar(185)", maxLength: 185, nullable: false),
                    Correct_Answer = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Forth_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Forth_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frist_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Frist_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quest_Type = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Second_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Second_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Third_Answer = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: true),
                    Third_Answer_Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralExamQuestions", x => new { x.TeacherId, x.ExamTitle, x.Academy_Year, x.Quest });
                });

            migrationBuilder.CreateTable(
                name: "GeneralExamResults",
                columns: table => new
                {
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamTitle = table.Column<string>(type: "nvarchar(185)", maxLength: 185, nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Correct_Answers_No = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Time = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralExamResults", x => new { x.TeacherId, x.ExamTitle, x.StudentId });
                    table.ForeignKey(
                        name: "FK_GeneralExamResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneralExamResults_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralExams",
                columns: table => new
                {
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Academy_Year = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Exam_Duration = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FinishExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartExamDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralExams", x => new { x.TeacherId, x.Title, x.Academy_Year });
                    table.ForeignKey(
                        name: "FK_GeneralExams_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralExamResults_StudentId",
                table: "GeneralExamResults",
                column: "StudentId");
        }
    }
}
