using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class UpdateDBforclassSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "CLASS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "R_Class_Schedule",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScheduleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Class_Schedule", x => new { x.ScheduleId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_Class_Schedule",
                        column: x => x.ClassId,
                        principalTable: "CLASS",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Schedule_Class",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId");
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 17, 40, 27, 876, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 1, 17, 40, 27, 876, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 2, 1, 17, 40, 27, 876, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.CreateIndex(
                name: "IX_R_Class_Schedule_ClassId",
                table: "R_Class_Schedule",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_Class_Schedule");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "CLASS");

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
    }
}
