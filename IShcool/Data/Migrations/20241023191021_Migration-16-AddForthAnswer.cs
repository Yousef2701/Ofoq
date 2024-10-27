using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration16AddForthAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Forth_Answer",
                table: "GeneralExamQuestions",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Forth_Answer_Url",
                table: "GeneralExamQuestions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Forth_Answer",
                table: "GeneralExamQuestions");

            migrationBuilder.DropColumn(
                name: "Forth_Answer_Url",
                table: "GeneralExamQuestions");
        }
    }
}
