using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class UpdateClassSubjectRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLASS_Subjects_SubjectId",
                table: "CLASS");

            migrationBuilder.DropIndex(
                name: "IX_CLASS_SubjectId",
                table: "CLASS");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "CLASS");

            migrationBuilder.CreateTable(
                name: "R_Class_Subject",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Class_Subject", x => new { x.SubjectId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_Class_Subject",
                        column: x => x.ClassId,
                        principalTable: "CLASS",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Subject_Class",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_R_Class_Subject_ClassId",
                table: "R_Class_Subject",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_Class_Subject");

            migrationBuilder.AddColumn<string>(
                name: "SubjectId",
                table: "CLASS",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CLASS_SubjectId",
                table: "CLASS",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLASS_Subjects_SubjectId",
                table: "CLASS",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");
        }
    }
}
