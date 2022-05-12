using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeacherAssisstantBE.Migrations
{
    public partial class AddSelectedAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResultDate",
                table: "Result",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "SelectedAnswer",
                columns: table => new
                {
                    SelectedAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    SeleAnswerId = table.Column<int>(type: "int", nullable: false),
                    CorrAnswerId = table.Column<int>(type: "int", nullable: false),
                    QuizDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekNumber = table.Column<int>(type: "int", nullable: false),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedAnswer", x => x.SelectedAnswerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedAnswer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResultDate",
                table: "Result",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
