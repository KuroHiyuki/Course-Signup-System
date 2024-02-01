using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class Update12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLASS_Schedules_ScheduleId",
                table: "CLASS");

            migrationBuilder.DropIndex(
                name: "IX_CLASS_ScheduleId",
                table: "CLASS");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "CLASS");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 17, 44, 40, 161, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 1, 17, 44, 40, 161, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 2, 1, 17, 44, 40, 161, DateTimeKind.Local).AddTicks(2300) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScheduleId",
                table: "CLASS",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 17, 40, 27, 876, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 1, 17, 40, 27, 876, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 2, 1, 17, 40, 27, 876, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.CreateIndex(
                name: "IX_CLASS_ScheduleId",
                table: "CLASS",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLASS_Schedules_ScheduleId",
                table: "CLASS",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "ScheduleId");
        }
    }
}
