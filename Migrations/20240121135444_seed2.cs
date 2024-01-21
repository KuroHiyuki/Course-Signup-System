using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 54, 44, 53, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 1, 21, 20, 54, 44, 53, DateTimeKind.Local).AddTicks(9054) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 34, 245, DateTimeKind.Local).AddTicks(3198), new DateTime(2024, 1, 21, 20, 46, 34, 245, DateTimeKind.Local).AddTicks(3208) });
        }
    }
}
