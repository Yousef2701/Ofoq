using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IShcool.Data.Migrations
{
    public partial class Migration5DeleteTeacherIdColumnFromLessonTestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonsTest",
                table: "LessonsTest");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "LessonsTest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonsTest",
                table: "LessonsTest",
                columns: new[] { "Vedio_Url", "Quest" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonsTest",
                table: "LessonsTest");

            migrationBuilder.AddColumn<string>(
                name: "TeacherId",
                table: "LessonsTest",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonsTest",
                table: "LessonsTest",
                columns: new[] { "TeacherId", "Vedio_Url", "Quest" });
        }
    }
}
