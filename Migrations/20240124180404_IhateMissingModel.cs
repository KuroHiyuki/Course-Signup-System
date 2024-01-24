using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class IhateMissingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GetProgramsProgramId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramId",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_GetProgramsProgramId",
                table: "Subjects",
                column: "GetProgramsProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Programs_GetProgramsProgramId",
                table: "Subjects",
                column: "GetProgramsProgramId",
                principalTable: "Programs",
                principalColumn: "ProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Programs_GetProgramsProgramId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_GetProgramsProgramId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "GetProgramsProgramId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Subjects");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 23, 27, 6, 18, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 27, 6, 17, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 1, 24, 23, 27, 6, 17, DateTimeKind.Local).AddTicks(5909) });
        }
    }
}
