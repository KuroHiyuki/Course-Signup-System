using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class SeedRolePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "R_Role_Permission",
                columns: new[] { "PermissionId", "RoleId", "UpdateDate" },
                values: new object[,]
                {
                    { "1.2", "GV01", null },
                    { "1.4", "GV01", null },
                    { "1.5", "GV01", null },
                    { "2.1", "GV01", null },
                    { "2.4", "GV01", null },
                    { "2.5", "GV01", null },
                    { "3.6", "GV01", null },
                    { "4.16", "GV01", null },
                    { "4.17", "GV01", null },
                    { "4.18", "GV01", null },
                    { "4.19", "GV01", null },
                    { "4.20", "GV01", null },
                    { "4.21", "GV01", null },
                    { "4.22", "GV01", null },
                    { "4.23", "GV01", null },
                    { "4.24", "GV01", null },
                    { "4.25", "GV01", null },
                    { "4.26", "GV01", null },
                    { "4.27", "GV01", null },
                    { "4.28", "GV01", null },
                    { "4.29", "GV01", null },
                    { "4.30", "GV01", null },
                    { "4.31", "GV01", null },
                    { "5.1", "GV01", null },
                    { "1.3", "HV01", null },
                    { "1.4", "HV01", null },
                    { "2.3", "HV01", null },
                    { "2.4", "HV01", null },
                    { "2.5", "HV01", null },
                    { "7.1", "HV01", null },
                    { "1.1", "QTV01", null },
                    { "1.3", "QTV01", null },
                    { "1.4", "QTV01", null },
                    { "1.5", "QTV01", null },
                    { "2.1", "QTV01", null },
                    { "2.2", "QTV01", null },
                    { "2.4", "QTV01", null },
                    { "2.5", "QTV01", null },
                    { "2.6", "QTV01", null },
                    { "2.7", "QTV01", null },
                    { "3.1", "QTV01", null },
                    { "3.2", "QTV01", null }
                });

            migrationBuilder.InsertData(
                table: "R_Role_Permission",
                columns: new[] { "PermissionId", "RoleId", "UpdateDate" },
                values: new object[,]
                {
                    { "3.3", "QTV01", null },
                    { "3.4", "QTV01", null },
                    { "3.5", "QTV01", null },
                    { "3.6", "QTV01", null },
                    { "3.7", "QTV01", null },
                    { "3.8", "QTV01", null },
                    { "3.9", "QTV01", null },
                    { "4.1", "QTV01", null },
                    { "4.10", "QTV01", null },
                    { "4.11", "QTV01", null },
                    { "4.12", "QTV01", null },
                    { "4.13", "QTV01", null },
                    { "4.14", "QTV01", null },
                    { "4.15", "QTV01", null },
                    { "4.16", "QTV01", null },
                    { "4.17", "QTV01", null },
                    { "4.18", "QTV01", null },
                    { "4.19", "QTV01", null },
                    { "4.2", "QTV01", null },
                    { "4.20", "QTV01", null },
                    { "4.21", "QTV01", null },
                    { "4.22", "QTV01", null },
                    { "4.23", "QTV01", null },
                    { "4.24", "QTV01", null },
                    { "4.25", "QTV01", null },
                    { "4.26", "QTV01", null },
                    { "4.27", "QTV01", null },
                    { "4.28", "QTV01", null },
                    { "4.29", "QTV01", null },
                    { "4.3", "QTV01", null },
                    { "4.30", "QTV01", null },
                    { "4.31", "QTV01", null },
                    { "4.4", "QTV01", null },
                    { "4.5", "QTV01", null },
                    { "4.6", "QTV01", null },
                    { "4.7", "QTV01", null },
                    { "4.8", "QTV01", null },
                    { "4.9", "QTV01", null },
                    { "5.1", "QTV01", null },
                    { "5.2", "QTV01", null },
                    { "5.3", "QTV01", null },
                    { "5.4", "QTV01", null }
                });

            migrationBuilder.InsertData(
                table: "R_Role_Permission",
                columns: new[] { "PermissionId", "RoleId", "UpdateDate" },
                values: new object[,]
                {
                    { "6.1", "QTV01", null },
                    { "7.1", "QTV01", null },
                    { "7.2", "QTV01", null },
                    { "7.3", "QTV01", null },
                    { "7.4", "QTV01", null },
                    { "7.5", "QTV01", null },
                    { "7.6", "QTV01", null },
                    { "7.7", "QTV01", null },
                    { "1.1", "QTV02", null },
                    { "1.3", "QTV02", null },
                    { "1.4", "QTV02", null },
                    { "1.5", "QTV02", null },
                    { "2.1", "QTV02", null },
                    { "2.2", "QTV02", null },
                    { "2.4", "QTV02", null },
                    { "2.5", "QTV02", null },
                    { "2.6", "QTV02", null },
                    { "2.7", "QTV02", null },
                    { "3.1", "QTV02", null },
                    { "3.2", "QTV02", null },
                    { "3.3", "QTV02", null },
                    { "3.4", "QTV02", null },
                    { "3.5", "QTV02", null },
                    { "3.6", "QTV02", null },
                    { "3.7", "QTV02", null },
                    { "3.8", "QTV02", null },
                    { "3.9", "QTV02", null },
                    { "4.1", "QTV02", null },
                    { "4.10", "QTV02", null },
                    { "4.11", "QTV02", null },
                    { "4.12", "QTV02", null },
                    { "4.13", "QTV02", null },
                    { "4.14", "QTV02", null },
                    { "4.15", "QTV02", null },
                    { "4.16", "QTV02", null },
                    { "4.17", "QTV02", null },
                    { "4.18", "QTV02", null },
                    { "4.19", "QTV02", null },
                    { "4.2", "QTV02", null },
                    { "4.20", "QTV02", null },
                    { "4.21", "QTV02", null },
                    { "4.22", "QTV02", null }
                });

            migrationBuilder.InsertData(
                table: "R_Role_Permission",
                columns: new[] { "PermissionId", "RoleId", "UpdateDate" },
                values: new object[,]
                {
                    { "4.23", "QTV02", null },
                    { "4.24", "QTV02", null },
                    { "4.25", "QTV02", null },
                    { "4.26", "QTV02", null },
                    { "4.27", "QTV02", null },
                    { "4.28", "QTV02", null },
                    { "4.29", "QTV02", null },
                    { "4.3", "QTV02", null },
                    { "4.30", "QTV02", null },
                    { "4.31", "QTV02", null },
                    { "4.4", "QTV02", null },
                    { "4.5", "QTV02", null },
                    { "4.6", "QTV02", null },
                    { "4.7", "QTV02", null },
                    { "4.8", "QTV02", null },
                    { "4.9", "QTV02", null },
                    { "5.1", "QTV02", null },
                    { "5.2", "QTV02", null },
                    { "5.3", "QTV02", null },
                    { "5.4", "QTV02", null },
                    { "6.1", "QTV02", null },
                    { "7.1", "QTV02", null },
                    { "7.2", "QTV02", null },
                    { "7.3", "QTV02", null },
                    { "7.4", "QTV02", null },
                    { "7.5", "QTV02", null },
                    { "7.6", "QTV02", null },
                    { "7.7", "QTV02", null },
                    { "1.1", "QTV03", null },
                    { "1.3", "QTV03", null },
                    { "1.4", "QTV03", null },
                    { "1.5", "QTV03", null },
                    { "2.1", "QTV03", null },
                    { "2.2", "QTV03", null },
                    { "2.4", "QTV03", null },
                    { "2.5", "QTV03", null },
                    { "2.6", "QTV03", null },
                    { "2.7", "QTV03", null },
                    { "3.1", "QTV03", null },
                    { "3.2", "QTV03", null },
                    { "3.3", "QTV03", null },
                    { "3.4", "QTV03", null }
                });

            migrationBuilder.InsertData(
                table: "R_Role_Permission",
                columns: new[] { "PermissionId", "RoleId", "UpdateDate" },
                values: new object[,]
                {
                    { "3.5", "QTV03", null },
                    { "3.6", "QTV03", null },
                    { "3.7", "QTV03", null },
                    { "3.8", "QTV03", null },
                    { "3.9", "QTV03", null },
                    { "4.1", "QTV03", null },
                    { "4.10", "QTV03", null },
                    { "4.11", "QTV03", null },
                    { "4.12", "QTV03", null },
                    { "4.13", "QTV03", null },
                    { "4.14", "QTV03", null },
                    { "4.15", "QTV03", null },
                    { "4.16", "QTV03", null },
                    { "4.17", "QTV03", null },
                    { "4.18", "QTV03", null },
                    { "4.19", "QTV03", null },
                    { "4.2", "QTV03", null },
                    { "4.20", "QTV03", null },
                    { "4.21", "QTV03", null },
                    { "4.22", "QTV03", null },
                    { "4.23", "QTV03", null },
                    { "4.24", "QTV03", null },
                    { "4.25", "QTV03", null },
                    { "4.26", "QTV03", null },
                    { "4.27", "QTV03", null },
                    { "4.28", "QTV03", null },
                    { "4.29", "QTV03", null },
                    { "4.3", "QTV03", null },
                    { "4.30", "QTV03", null },
                    { "4.31", "QTV03", null },
                    { "4.4", "QTV03", null },
                    { "4.5", "QTV03", null },
                    { "4.6", "QTV03", null },
                    { "4.7", "QTV03", null },
                    { "4.8", "QTV03", null },
                    { "4.9", "QTV03", null },
                    { "5.1", "QTV03", null },
                    { "5.2", "QTV03", null },
                    { "5.3", "QTV03", null },
                    { "5.4", "QTV03", null },
                    { "6.1", "QTV03", null },
                    { "7.1", "QTV03", null }
                });

            migrationBuilder.InsertData(
                table: "R_Role_Permission",
                columns: new[] { "PermissionId", "RoleId", "UpdateDate" },
                values: new object[,]
                {
                    { "7.2", "QTV03", null },
                    { "7.3", "QTV03", null },
                    { "7.4", "QTV03", null },
                    { "7.5", "QTV03", null },
                    { "7.6", "QTV03", null },
                    { "7.7", "QTV03", null },
                    { "1.1", "QTV04", null },
                    { "1.3", "QTV04", null },
                    { "1.4", "QTV04", null },
                    { "1.5", "QTV04", null },
                    { "2.1", "QTV04", null },
                    { "2.2", "QTV04", null },
                    { "2.4", "QTV04", null },
                    { "2.5", "QTV04", null },
                    { "2.6", "QTV04", null },
                    { "2.7", "QTV04", null },
                    { "3.1", "QTV04", null },
                    { "3.2", "QTV04", null },
                    { "3.3", "QTV04", null },
                    { "3.4", "QTV04", null },
                    { "3.5", "QTV04", null },
                    { "3.6", "QTV04", null },
                    { "3.7", "QTV04", null },
                    { "3.8", "QTV04", null },
                    { "3.9", "QTV04", null },
                    { "4.1", "QTV04", null },
                    { "4.10", "QTV04", null },
                    { "4.11", "QTV04", null },
                    { "4.12", "QTV04", null },
                    { "4.13", "QTV04", null },
                    { "4.14", "QTV04", null },
                    { "4.15", "QTV04", null },
                    { "4.16", "QTV04", null },
                    { "4.17", "QTV04", null },
                    { "4.18", "QTV04", null },
                    { "4.19", "QTV04", null },
                    { "4.2", "QTV04", null },
                    { "4.20", "QTV04", null },
                    { "4.21", "QTV04", null },
                    { "4.22", "QTV04", null },
                    { "4.23", "QTV04", null },
                    { "4.24", "QTV04", null }
                });

            migrationBuilder.InsertData(
                table: "R_Role_Permission",
                columns: new[] { "PermissionId", "RoleId", "UpdateDate" },
                values: new object[,]
                {
                    { "4.25", "QTV04", null },
                    { "4.26", "QTV04", null },
                    { "4.27", "QTV04", null },
                    { "4.28", "QTV04", null },
                    { "4.29", "QTV04", null },
                    { "4.3", "QTV04", null },
                    { "4.30", "QTV04", null },
                    { "4.31", "QTV04", null },
                    { "4.4", "QTV04", null },
                    { "4.5", "QTV04", null },
                    { "4.6", "QTV04", null },
                    { "4.7", "QTV04", null },
                    { "4.8", "QTV04", null },
                    { "4.9", "QTV04", null },
                    { "5.1", "QTV04", null },
                    { "5.2", "QTV04", null },
                    { "5.3", "QTV04", null },
                    { "5.4", "QTV04", null },
                    { "6.1", "QTV04", null },
                    { "7.1", "QTV04", null },
                    { "7.2", "QTV04", null },
                    { "7.3", "QTV04", null },
                    { "7.4", "QTV04", null },
                    { "7.5", "QTV04", null },
                    { "7.6", "QTV04", null },
                    { "7.7", "QTV04", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 11, 17, 215, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 1, 21, 21, 11, 17, 215, DateTimeKind.Local).AddTicks(9822) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.2", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.4", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.5", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.1", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.4", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.5", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.6", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.16", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.17", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.18", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.19", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.20", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.21", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.22", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.23", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.24", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.25", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.26", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.27", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.28", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.29", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.30", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.31", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.1", "GV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.3", "HV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.4", "HV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.3", "HV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.4", "HV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.5", "HV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.1", "HV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.1", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.3", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.4", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.5", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.1", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.2", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.4", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.5", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.6", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.7", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.1", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.2", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.3", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.4", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.5", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.6", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.7", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.8", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.9", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.1", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.10", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.11", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.12", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.13", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.14", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.15", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.16", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.17", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.18", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.19", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.2", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.20", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.21", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.22", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.23", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.24", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.25", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.26", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.27", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.28", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.29", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.3", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.30", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.31", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.4", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.5", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.6", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.7", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.8", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.9", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.1", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.2", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.3", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.4", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "6.1", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.1", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.2", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.3", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.4", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.5", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.6", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.7", "QTV01" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.1", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.3", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.4", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.5", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.1", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.2", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.4", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.5", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.6", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.7", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.1", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.2", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.3", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.4", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.5", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.6", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.7", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.8", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.9", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.1", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.10", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.11", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.12", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.13", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.14", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.15", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.16", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.17", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.18", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.19", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.2", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.20", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.21", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.22", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.23", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.24", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.25", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.26", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.27", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.28", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.29", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.3", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.30", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.31", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.4", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.5", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.6", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.7", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.8", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.9", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.1", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.2", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.3", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.4", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "6.1", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.1", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.2", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.3", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.4", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.5", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.6", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.7", "QTV02" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.1", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.3", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.4", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.5", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.1", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.2", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.4", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.5", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.6", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.7", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.1", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.2", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.3", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.4", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.5", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.6", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.7", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.8", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.9", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.1", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.10", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.11", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.12", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.13", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.14", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.15", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.16", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.17", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.18", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.19", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.2", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.20", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.21", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.22", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.23", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.24", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.25", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.26", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.27", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.28", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.29", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.3", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.30", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.31", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.4", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.5", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.6", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.7", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.8", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.9", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.1", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.2", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.3", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.4", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "6.1", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.1", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.2", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.3", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.4", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.5", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.6", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.7", "QTV03" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.1", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.3", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.4", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "1.5", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.1", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.2", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.4", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.5", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.6", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "2.7", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.1", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.2", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.3", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.4", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.5", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.6", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.7", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.8", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "3.9", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.1", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.10", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.11", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.12", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.13", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.14", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.15", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.16", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.17", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.18", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.19", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.2", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.20", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.21", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.22", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.23", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.24", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.25", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.26", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.27", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.28", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.29", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.3", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.30", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.31", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.4", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.5", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.6", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.7", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.8", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "4.9", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.1", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.2", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.3", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "5.4", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "6.1", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.1", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.2", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.3", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.4", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.5", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.6", "QTV04" });

            migrationBuilder.DeleteData(
                table: "R_Role_Permission",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { "7.7", "QTV04" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 54, 44, 53, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 1, 21, 20, 54, 44, 53, DateTimeKind.Local).AddTicks(9054) });
        }
    }
}
