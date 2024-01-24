using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class Thietkekylamroima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiredColumn",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "ScoreColumn",
                table: "Score");

            migrationBuilder.AddColumn<int>(
                name: "RequiredColumn",
                table: "R_Subject_Score",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScoreColumn",
                table: "R_Subject_Score",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 1, 42, 43, 276, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 1, 42, 43, 276, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 1, 25, 1, 42, 43, 276, DateTimeKind.Local).AddTicks(865) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiredColumn",
                table: "R_Subject_Score");

            migrationBuilder.DropColumn(
                name: "ScoreColumn",
                table: "R_Subject_Score");

            migrationBuilder.AddColumn<int>(
                name: "RequiredColumn",
                table: "Score",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScoreColumn",
                table: "Score",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 1, 4, 2, 609, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 1, 4, 2, 608, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 1, 25, 1, 4, 2, 608, DateTimeKind.Local).AddTicks(9819) });
        }
    }
}
