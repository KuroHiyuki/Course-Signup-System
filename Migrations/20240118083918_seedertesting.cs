using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    public partial class seedertesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

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
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    ProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.ProgramId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAirCondition = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScheduleName = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
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
                name: "Vactions",
                columns: table => new
                {
                    VacationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VacationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vactions", x => x.VacationId);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyId);
                    table.ForeignKey(
                        name: "FK_Faculties_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacultyId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentNumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Student",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSubject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Teacher",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CLASS",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxStudent = table.Column<int>(type: "int", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: true),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ClassId", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_CLASS_Fees_FeeId",
                        column: x => x.FeeId,
                        principalTable: "Fees",
                        principalColumn: "FeeId");
                    table.ForeignKey(
                        name: "FK_CLASS_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId");
                    table.ForeignKey(
                        name: "FK_CLASS_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId");
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "IsAdmin", "RoleName" },
                values: new object[,]
                {
                    { "GV01", false, "Giáo viên" },
                    { "HV01", false, "Học viên" },
                    { "QTV01", true, "Quản trị viên" },
                    { "QTV02", true, "Bộ phân Kế Toán" },
                    { "QTV03", true, "Ban giám đốc" },
                    { "QTV04", true, "Bộ phân ghi danh" }
                });

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
                name: "IX_Faculties_DepartmentId",
                table: "Faculties",
                column: "DepartmentId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_FacultyId",
                table: "Subjects",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Vactions");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "CLASS");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "FeeTypes");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
