using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class Relationshipadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administators");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Class",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "TimeOnly",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Class");

            migrationBuilder.RenameTable(
                name: "Class",
                newName: "CLASS");

            migrationBuilder.RenameColumn(
                name: "Term",
                table: "Programs",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "TuitionFee",
                table: "CLASS",
                newName: "Term");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GetUserUserId",
                table: "Teachers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacultyId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GetUserUserId",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParentEmail",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentNumberPhone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStart",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAirCondition",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Roles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Programs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Programs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                table: "Faculties",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Faculties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "ScheduleId",
                table: "CLASS",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeeId",
                table: "CLASS",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "CLASS",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxStudent",
                table: "CLASS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubjectId",
                table: "CLASS",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "ClassId",
                table: "CLASS",
                column: "ClassId");

            migrationBuilder.CreateTable(
                name: "FeeTypes",
                columns: table => new
                {
                    TypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateOfCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeTypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "R_Class_Program",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Class_Program", x => new { x.ProgramId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_Class_Program",
                        column: x => x.ClassId,
                        principalTable: "CLASS",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Program_Class",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "ProgramId");
                });

            migrationBuilder.CreateTable(
                name: "R_Class_Room",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AlterRoomId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Class_Room", x => new { x.RoomId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_Class_Room",
                        column: x => x.ClassId,
                        principalTable: "CLASS",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Room_Class",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId");
                });

            migrationBuilder.CreateTable(
                name: "R_Role_Permission",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Role_Permission", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_Permission_Role",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId");
                    table.ForeignKey(
                        name: "FK_Role_Permission",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateTable(
                name: "R_Salary",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RateOfCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Salary", x => new { x.UserId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_Class_Salary",
                        column: x => x.ClassId,
                        principalTable: "CLASS",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_User_Salary",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "R_Student_Class",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPayment = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Student_Class", x => new { x.UserId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_Class_Student",
                        column: x => x.ClassId,
                        principalTable: "CLASS",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Student_Class",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "R_Teacher_Class",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPayment = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Teacher_Class", x => new { x.UserId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_Class_Teacher",
                        column: x => x.ClassId,
                        principalTable: "CLASS",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Teacher_Class",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScoreColumn = table.Column<int>(type: "int", nullable: false),
                    RequiredColumn = table.Column<int>(type: "int", nullable: false),
                    MultiplierScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreId);
                });

            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    FeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FeeCost = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetFeeTypeTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.FeeId);
                    table.ForeignKey(
                        name: "FK_Fees_FeeTypes_GetFeeTypeTypeId",
                        column: x => x.GetFeeTypeTypeId,
                        principalTable: "FeeTypes",
                        principalColumn: "TypeId");
                });

            migrationBuilder.CreateTable(
                name: "R_Student_Score",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsTerminal = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Student_Score", x => new { x.UserId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Score_Student",
                        column: x => x.ScoreId,
                        principalTable: "Score",
                        principalColumn: "ScoreId");
                    table.ForeignKey(
                        name: "FK_Student_Score",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Subject_Student",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId");
                });

            migrationBuilder.CreateTable(
                name: "R_Subject_Score",
                columns: table => new
                {
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Subject_Score", x => new { x.SubjectId, x.ScoreId });
                    table.ForeignKey(
                        name: "FK_Score_Subject",
                        column: x => x.ScoreId,
                        principalTable: "Score",
                        principalColumn: "ScoreId");
                    table.ForeignKey(
                        name: "FK_Subject_Score",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_GetUserUserId",
                table: "Teachers",
                column: "GetUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_FacultyId",
                table: "Subjects",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GetUserUserId",
                table: "Students",
                column: "GetUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_DepartmentId",
                table: "Faculties",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CLASS_FeeId",
                table: "CLASS",
                column: "FeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CLASS_ScheduleId",
                table: "CLASS",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_CLASS_SubjectId",
                table: "CLASS",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Fees_GetFeeTypeTypeId",
                table: "Fees",
                column: "GetFeeTypeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Class_Program_ClassId",
                table: "R_Class_Program",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Class_Room_ClassId",
                table: "R_Class_Room",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Role_Permission_PermissionId",
                table: "R_Role_Permission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Salary_ClassId",
                table: "R_Salary",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Student_Class_ClassId",
                table: "R_Student_Class",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Student_Score_ScoreId",
                table: "R_Student_Score",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Student_Score_SubjectId",
                table: "R_Student_Score",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Subject_Score_ScoreId",
                table: "R_Subject_Score",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Teacher_Class_ClassId",
                table: "R_Teacher_Class",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLASS_Fees_FeeId",
                table: "CLASS",
                column: "FeeId",
                principalTable: "Fees",
                principalColumn: "FeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLASS_Schedules_ScheduleId",
                table: "CLASS",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CLASS_Subjects_SubjectId",
                table: "CLASS",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Departments_DepartmentId",
                table: "Faculties",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_GetUserUserId",
                table: "Students",
                column: "GetUserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Faculties_FacultyId",
                table: "Subjects",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Users_GetUserUserId",
                table: "Teachers",
                column: "GetUserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLASS_Fees_FeeId",
                table: "CLASS");

            migrationBuilder.DropForeignKey(
                name: "FK_CLASS_Schedules_ScheduleId",
                table: "CLASS");

            migrationBuilder.DropForeignKey(
                name: "FK_CLASS_Subjects_SubjectId",
                table: "CLASS");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Departments_DepartmentId",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_GetUserUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Faculties_FacultyId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Users_GetUserUserId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "R_Class_Program");

            migrationBuilder.DropTable(
                name: "R_Class_Room");

            migrationBuilder.DropTable(
                name: "R_Role_Permission");

            migrationBuilder.DropTable(
                name: "R_Salary");

            migrationBuilder.DropTable(
                name: "R_Student_Class");

            migrationBuilder.DropTable(
                name: "R_Student_Score");

            migrationBuilder.DropTable(
                name: "R_Subject_Score");

            migrationBuilder.DropTable(
                name: "R_Teacher_Class");

            migrationBuilder.DropTable(
                name: "FeeTypes");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_GetUserUserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_FacultyId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_GetUserUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_DepartmentId",
                table: "Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "ClassId",
                table: "CLASS");

            migrationBuilder.DropIndex(
                name: "IX_CLASS_FeeId",
                table: "CLASS");

            migrationBuilder.DropIndex(
                name: "IX_CLASS_ScheduleId",
                table: "CLASS");

            migrationBuilder.DropIndex(
                name: "IX_CLASS_SubjectId",
                table: "CLASS");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GetUserUserId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "GetUserUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentEmail",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentNumberPhone",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TimeStart",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "IsAirCondition",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "FeeId",
                table: "CLASS");

            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "CLASS");

            migrationBuilder.DropColumn(
                name: "MaxStudent",
                table: "CLASS");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "CLASS");

            migrationBuilder.RenameTable(
                name: "CLASS",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Programs",
                newName: "Term");

            migrationBuilder.RenameColumn(
                name: "Term",
                table: "Class",
                newName: "TuitionFee");

            migrationBuilder.AddColumn<string>(
                name: "SubjectId",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOnly",
                table: "Schedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ScheduleId",
                table: "Class",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discount",
                table: "Class",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Class",
                table: "Class",
                column: "ClassId");

            migrationBuilder.CreateTable(
                name: "Administators",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administators", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    MarkId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarkName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.MarkId);
                });
        }
    }
}
