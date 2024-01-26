using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class AgainandAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RateOfCharge",
                table: "R_Salary",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Allowance",
                table: "R_Salary",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "RateOfCharge",
                table: "R_Salary",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Allowance",
                table: "R_Salary",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
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
        }
    }
}
