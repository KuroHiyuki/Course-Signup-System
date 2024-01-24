using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class UpdateAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProgramId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 3, 10, 0, 348, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 10, 0, 347, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 1, 25, 3, 10, 0, 347, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ProgramId",
                table: "Subjects",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Program",
                table: "Subjects",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "ProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Program",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ProgramId",
                table: "Subjects");

            migrationBuilder.AlterColumn<string>(
                name: "ProgramId",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GetProgramsProgramId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 2, 45, 52, 590, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 45, 52, 590, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 1, 25, 2, 45, 52, 590, DateTimeKind.Local).AddTicks(728) });

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
    }
}
