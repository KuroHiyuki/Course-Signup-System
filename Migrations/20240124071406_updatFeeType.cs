using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class updatFeeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RateOfCharge",
                table: "FeeTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "FeeTypes",
                columns: new[] { "TypeId", "Description", "RateOfCharge", "TypeName" },
                values: new object[,]
                {
                    { "ALLCOURSE100%", "Tính cả khoá nhưng có thể chỉ riêng từng lớp", 100, "Thu toàn bộ khoá học 100%" },
                    { "ALLCOURSE50%", "Tính cả khoá nhưng có thể chỉ riêng từng lớp", 50, "Thu toàn bộ khoá học 50%" },
                    { "HAlFCOURSE", "Chia học phí thành 2 đợt", 50, "Thu chia thành 2 đợt" },
                    { "PARTCOURSE", "Thu trong một lần", 100, "Thu theo từng môn hoặc từng lớp" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 14, 5, 267, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 1, 24, 14, 14, 5, 267, DateTimeKind.Local).AddTicks(8559) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FeeTypes",
                keyColumn: "TypeId",
                keyValue: "ALLCOURSE100%");

            migrationBuilder.DeleteData(
                table: "FeeTypes",
                keyColumn: "TypeId",
                keyValue: "ALLCOURSE50%");

            migrationBuilder.DeleteData(
                table: "FeeTypes",
                keyColumn: "TypeId",
                keyValue: "HAlFCOURSE");

            migrationBuilder.DeleteData(
                table: "FeeTypes",
                keyColumn: "TypeId",
                keyValue: "PARTCOURSE");

            migrationBuilder.AlterColumn<decimal>(
                name: "RateOfCharge",
                table: "FeeTypes",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 23, 16, 38, 15, 451, DateTimeKind.Local).AddTicks(152), new DateTime(2024, 1, 23, 16, 38, 15, 451, DateTimeKind.Local).AddTicks(161) });
        }
    }
}
