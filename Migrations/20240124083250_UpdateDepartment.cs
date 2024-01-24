using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class UpdateDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: "NOTSET_DEPARTMENT",
                column: "DepartmentName",
                value: "Chưa set-up Khoa/ khối");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 15, 32, 48, 154, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 15, 32, 48, 151, DateTimeKind.Local).AddTicks(9374), new DateTime(2024, 1, 24, 15, 32, 48, 151, DateTimeKind.Local).AddTicks(9387) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: "NOTSET_DEPARTMENT",
                column: "DepartmentName",
                value: null);

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
    }
}
