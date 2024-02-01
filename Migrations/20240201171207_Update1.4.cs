using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class Update14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_R_Student_Score",
                table: "R_Student_Score");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "R_Student_Score",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "R_Student_Score",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "MarkId",
                table: "R_Student_Score",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_Student_Score",
                table: "R_Student_Score",
                column: "MarkId");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 0, 12, 4, 752, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 12, 4, 750, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 2, 2, 0, 12, 4, 750, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.CreateIndex(
                name: "IX_R_Student_Score_UserId",
                table: "R_Student_Score",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_R_Student_Score",
                table: "R_Student_Score");

            migrationBuilder.DropIndex(
                name: "IX_R_Student_Score_UserId",
                table: "R_Student_Score");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "R_Student_Score");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "R_Student_Score",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "R_Student_Score",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_Student_Score",
                table: "R_Student_Score",
                columns: new[] { "UserId", "SubjectId" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 18, 0, 45, 794, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 0, 45, 793, DateTimeKind.Local).AddTicks(6497), new DateTime(2024, 2, 1, 18, 0, 45, 793, DateTimeKind.Local).AddTicks(6504) });
        }
    }
}
