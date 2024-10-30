using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration18UpdateGeneralExamQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "GeneralExamQuestions");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "GeneralExamQuestions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "GeneralExamQuestions",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "GeneralExamQuestions",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }
    }
}
