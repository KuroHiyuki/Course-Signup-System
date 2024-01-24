using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class Updateschedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleId", "Duration", "ScheduleName", "TimeStart" },
                values: new object[] { "NOTSET_SCHEDULE", 0m, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 14, 50, 44, 422, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 50, 44, 422, DateTimeKind.Local).AddTicks(2425), new DateTime(2024, 1, 24, 14, 50, 44, 422, DateTimeKind.Local).AddTicks(2434) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: "NOTSET_SCHEDULE");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 14, 32, 29, 704, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 32, 29, 703, DateTimeKind.Local).AddTicks(8073), new DateTime(2024, 1, 24, 14, 32, 29, 703, DateTimeKind.Local).AddTicks(8081) });
        }
    }
}
