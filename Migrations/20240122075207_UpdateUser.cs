using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 22, 14, 52, 5, 866, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 1, 22, 14, 52, 5, 866, DateTimeKind.Local).AddTicks(8601) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 26, 52, 847, DateTimeKind.Local).AddTicks(8911), new DateTime(2024, 1, 21, 23, 26, 52, 847, DateTimeKind.Local).AddTicks(8923) });
        }
    }
}
