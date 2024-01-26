using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class UpdateSomething : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "R_Student_Class",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 9, 37, 37, 192, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 37, 37, 192, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 1, 25, 9, 37, 37, 192, DateTimeKind.Local).AddTicks(3023) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "R_Student_Class");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 6, 24, 59, 599, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 6, 24, 59, 598, DateTimeKind.Local).AddTicks(6865), new DateTime(2024, 1, 25, 6, 24, 59, 598, DateTimeKind.Local).AddTicks(6875) });
        }
    }
}
