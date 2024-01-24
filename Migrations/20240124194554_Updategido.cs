using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class Updategido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Student",
                table: "R_Student_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Score",
                table: "R_Student_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Student",
                table: "R_Student_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_Subject",
                table: "R_Subject_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Score",
                table: "R_Subject_Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Score",
                table: "Score");

            migrationBuilder.RenameTable(
                name: "Score",
                newName: "Scores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scores",
                table: "Scores",
                column: "ScoreId");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 2, 45, 52, 590, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 45, 52, 590, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 1, 25, 2, 45, 52, 590, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Student1",
                table: "R_Student_Score",
                column: "ScoreId",
                principalTable: "Scores",
                principalColumn: "ScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Score1",
                table: "R_Student_Score",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Student1",
                table: "R_Student_Score",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Subject1",
                table: "R_Subject_Score",
                column: "ScoreId",
                principalTable: "Scores",
                principalColumn: "ScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Score1",
                table: "R_Subject_Score",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Student1",
                table: "R_Student_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Score1",
                table: "R_Student_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Student1",
                table: "R_Student_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_Subject1",
                table: "R_Subject_Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Score1",
                table: "R_Subject_Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scores",
                table: "Scores");

            migrationBuilder.RenameTable(
                name: "Scores",
                newName: "Score");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Score",
                table: "Score",
                column: "ScoreId");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "NOTSET_SUBJECT",
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 1, 42, 43, 276, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ADMIN0001",
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 25, 1, 42, 43, 276, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 1, 25, 1, 42, 43, 276, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Student",
                table: "R_Student_Score",
                column: "ScoreId",
                principalTable: "Score",
                principalColumn: "ScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Score",
                table: "R_Student_Score",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Student",
                table: "R_Student_Score",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Subject",
                table: "R_Subject_Score",
                column: "ScoreId",
                principalTable: "Score",
                principalColumn: "ScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Score",
                table: "R_Subject_Score",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");
        }
    }
}
