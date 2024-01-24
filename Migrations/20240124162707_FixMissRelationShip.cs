using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class FixMissRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                table: "CLASS",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CLASS_DepartmentId",
                table: "CLASS",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLASS_Departments_DepartmentId",
                table: "CLASS",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLASS_Departments_DepartmentId",
                table: "CLASS");

            migrationBuilder.DropIndex(
                name: "IX_CLASS_DepartmentId",
                table: "CLASS");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "CLASS");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 38, 16, 473, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 38, 16, 472, DateTimeKind.Local).AddTicks(6051), new DateTime(2024, 1, 24, 17, 38, 16, 472, DateTimeKind.Local).AddTicks(6060) });
        }
    }
}
