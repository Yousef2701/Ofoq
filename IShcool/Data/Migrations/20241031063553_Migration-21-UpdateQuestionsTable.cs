using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration21UpdateQuestionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Forth_Answer_Url",
                table: "LessonQuestions");

            migrationBuilder.DropColumn(
                name: "Frist_Answer_Url",
                table: "LessonQuestions");

            migrationBuilder.DropColumn(
                name: "Second_Answer_Url",
                table: "LessonQuestions");

            migrationBuilder.DropColumn(
                name: "Third_Answer_Url",
                table: "LessonQuestions");

            migrationBuilder.DropColumn(
                name: "Forth_Answer_Url",
                table: "ExamQuestions");

            migrationBuilder.DropColumn(
                name: "Frist_Answer_Url",
                table: "ExamQuestions");

            migrationBuilder.DropColumn(
                name: "Second_Answer_Url",
                table: "ExamQuestions");

            migrationBuilder.DropColumn(
                name: "Third_Answer_Url",
                table: "ExamQuestions");

            migrationBuilder.AlterColumn<string>(
                name: "Third_Answer",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Second_Answer",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Frist_Answer",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Forth_Answer",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Third_Answer",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Second_Answer",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Frist_Answer",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Forth_Answer",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Third_Answer",
                table: "LessonQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Second_Answer",
                table: "LessonQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Frist_Answer",
                table: "LessonQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Forth_Answer",
                table: "LessonQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Forth_Answer_Url",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frist_Answer_Url",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Second_Answer_Url",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Third_Answer_Url",
                table: "LessonQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Third_Answer",
                table: "ExamQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Second_Answer",
                table: "ExamQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Frist_Answer",
                table: "ExamQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Forth_Answer",
                table: "ExamQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Forth_Answer_Url",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frist_Answer_Url",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Second_Answer_Url",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Third_Answer_Url",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
