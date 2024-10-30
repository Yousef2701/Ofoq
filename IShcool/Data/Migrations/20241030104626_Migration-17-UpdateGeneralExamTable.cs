using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration17UpdateGeneralExamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "GeneralExams");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "GeneralExams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "GeneralExams",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "GeneralExams",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }
    }
}
