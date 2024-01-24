using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class UpdateNullValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CreatedDate", "DepartmentName", "DepartmentStatus" },
                values: new object[] { "NOTSET_DEPARTMENT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 32, 29, 703, DateTimeKind.Local).AddTicks(8073), new DateTime(2024, 1, 24, 14, 32, 29, 703, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyId", "CreatedDate", "DepartmentId", "FacultyName", "Note", "UpdateDate" },
                values: new object[] { "NOTSET_FACULTY", null, "NOTSET_DEPARTMENT", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CreatedDate", "FacultyId", "SubjectName", "SubjectNote" },
                values: new object[] { "NOTSET_SUBJECT", new DateTime(2024, 1, 24, 14, 32, 29, 704, DateTimeKind.Local).AddTicks(4252), "NOTSET_FACULTY", "Chưa set-up môn học", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: "NOTSET_FACULTY");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: "NOTSET_DEPARTMENT");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 14, 5, 267, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 1, 24, 14, 14, 5, 267, DateTimeKind.Local).AddTicks(8559) });
        }
    }
}
