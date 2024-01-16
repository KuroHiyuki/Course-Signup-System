﻿// <auto-generated />
using System;
using CourseSignupSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    [DbContext(typeof(CourseContext))]
    [Migration("20240116104000_Relationshipadd")]
    partial class Relationshipadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseSignupSystem.Models.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<int>("MaxStudent")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Term")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId")
                        .HasName("ClassId");

                    b.HasIndex("FeeId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CLASS", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Class_Program", b =>
                {
                    b.Property<string>("ProgramId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProgramId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("R_Class_Program", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Class_Room", b =>
                {
                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AlterRoomId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("R_Class_Room", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Department", b =>
                {
                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Faculty", b =>
                {
                    b.Property<string>("FacultyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FacultyId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Fee", b =>
                {
                    b.Property<string>("FeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("FeeCost")
                        .HasColumnType("int");

                    b.Property<string>("GetFeeTypeTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TypeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FeeId");

                    b.HasIndex("GetFeeTypeTypeId");

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.FeeType", b =>
                {
                    b.Property<string>("TypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RateOfCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("FeeTypes");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Permission", b =>
                {
                    b.Property<string>("PermissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Programs", b =>
                {
                    b.Property<string>("ProgramId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProgramName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProgramId");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Role_Permission", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PermissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("R_Role_Permission", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Room", b =>
                {
                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAirCondition")
                        .HasColumnType("bit");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Salary", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Allowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RateOfCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("R_Salary", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Schedule", b =>
                {
                    b.Property<string>("ScheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Duration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ScheduleName")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Score", b =>
                {
                    b.Property<string>("ScoreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MultiplierScore")
                        .HasColumnType("int");

                    b.Property<int>("RequiredColumn")
                        .HasColumnType("int");

                    b.Property<int>("ScoreColumn")
                        .HasColumnType("int");

                    b.Property<string>("ScoreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScoreId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Student", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GetUserUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentNumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("GetUserUserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Student_Class", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsPayment")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("R_Student_Class", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Student_Score", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsTerminal")
                        .HasColumnType("bit");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ScoreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "SubjectId");

                    b.HasIndex("ScoreId");

                    b.HasIndex("SubjectId");

                    b.ToTable("R_Student_Score", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Subject", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FacultyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectNote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Subject_Score", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ScoreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SubjectId", "ScoreId");

                    b.HasIndex("ScoreId");

                    b.ToTable("R_Subject_Score", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Teacher", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GetUserUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MainSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("GetUserUserId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Teacher_Class", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsPayment")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("R_Teacher_Class", (string)null);
                });

            modelBuilder.Entity("CourseSignupSystem.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Vaction", b =>
                {
                    b.Property<string>("VacationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VacationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacationId");

                    b.ToTable("Vactions");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Class", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Fee", "GetFee")
                        .WithMany("Co_Class")
                        .HasForeignKey("FeeId");

                    b.HasOne("CourseSignupSystem.Models.Schedule", "GetSchedule")
                        .WithMany("Co_Class")
                        .HasForeignKey("ScheduleId");

                    b.HasOne("CourseSignupSystem.Models.Subject", "GetSubject")
                        .WithMany("Co_Class")
                        .HasForeignKey("SubjectId");

                    b.Navigation("GetFee");

                    b.Navigation("GetSchedule");

                    b.Navigation("GetSubject");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Class_Program", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Class", "GetClass")
                        .WithMany("Co_Class_Program")
                        .HasForeignKey("ClassId")
                        .IsRequired()
                        .HasConstraintName("FK_Class_Program");

                    b.HasOne("CourseSignupSystem.Models.Programs", "GetProgram")
                        .WithMany("Co_Class_Prgram")
                        .HasForeignKey("ProgramId")
                        .IsRequired()
                        .HasConstraintName("FK_Program_Class");

                    b.Navigation("GetClass");

                    b.Navigation("GetProgram");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Class_Room", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Class", "GetClass")
                        .WithMany("Co_Class_Room")
                        .HasForeignKey("ClassId")
                        .IsRequired()
                        .HasConstraintName("FK_Class_Room");

                    b.HasOne("CourseSignupSystem.Models.Room", "GetRoom")
                        .WithMany("Co_Class_Room")
                        .HasForeignKey("RoomId")
                        .IsRequired()
                        .HasConstraintName("FK_Room_Class");

                    b.Navigation("GetClass");

                    b.Navigation("GetRoom");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Faculty", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Department", "GetDepartment")
                        .WithMany("Co_Faculties")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("GetDepartment");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Fee", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.FeeType", "GetFeeType")
                        .WithMany("Co_Fee")
                        .HasForeignKey("GetFeeTypeTypeId");

                    b.Navigation("GetFeeType");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Role_Permission", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Permission", "GetPermission")
                        .WithMany("Co_Role_Permission")
                        .HasForeignKey("PermissionId")
                        .IsRequired()
                        .HasConstraintName("FK_Permission_Role");

                    b.HasOne("CourseSignupSystem.Models.Role", "GetRole")
                        .WithMany("Co_Role_permission")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_Role_Permission");

                    b.Navigation("GetPermission");

                    b.Navigation("GetRole");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Salary", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Class", "GetClass")
                        .WithMany("Co_Salary")
                        .HasForeignKey("ClassId")
                        .IsRequired()
                        .HasConstraintName("FK_Class_Salary");

                    b.HasOne("CourseSignupSystem.Models.User", "GetUser")
                        .WithMany("Co_Salary")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_User_Salary");

                    b.Navigation("GetClass");

                    b.Navigation("GetUser");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Student", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.User", "GetUser")
                        .WithMany("Co_Student")
                        .HasForeignKey("GetUserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GetUser");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Student_Class", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Class", "GetClass")
                        .WithMany("Co_Student_Class")
                        .HasForeignKey("ClassId")
                        .IsRequired()
                        .HasConstraintName("FK_Class_Student");

                    b.HasOne("CourseSignupSystem.Models.User", "GetUser")
                        .WithMany("Co_Student_Class")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Class");

                    b.Navigation("GetClass");

                    b.Navigation("GetUser");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Student_Score", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Score", "GetScore")
                        .WithMany("Co_Student_Score")
                        .HasForeignKey("ScoreId")
                        .HasConstraintName("FK_Score_Student");

                    b.HasOne("CourseSignupSystem.Models.Subject", "GetSubject")
                        .WithMany("Co_Student_Score")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_Subject_Student");

                    b.HasOne("CourseSignupSystem.Models.User", "GetUser")
                        .WithMany("Co_Student_Score")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Score");

                    b.Navigation("GetScore");

                    b.Navigation("GetSubject");

                    b.Navigation("GetUser");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Subject", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Faculty", "GetFaculty")
                        .WithMany("Co_Subject")
                        .HasForeignKey("FacultyId");

                    b.Navigation("GetFaculty");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Subject_Score", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Score", "GetScore")
                        .WithMany("Co_Subject_Score")
                        .HasForeignKey("ScoreId")
                        .IsRequired()
                        .HasConstraintName("FK_Score_Subject");

                    b.HasOne("CourseSignupSystem.Models.Subject", "GetSubject")
                        .WithMany("Co_Subject_Score")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_Subject_Score");

                    b.Navigation("GetScore");

                    b.Navigation("GetSubject");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Teacher", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.User", "GetUser")
                        .WithMany("Co_Teacher")
                        .HasForeignKey("GetUserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GetUser");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Teacher_Class", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Class", "GetClass")
                        .WithMany("Co_Teacher_Class")
                        .HasForeignKey("ClassId")
                        .IsRequired()
                        .HasConstraintName("FK_Class_Teacher");

                    b.HasOne("CourseSignupSystem.Models.User", "GetUser")
                        .WithMany("Co_Teacher_Class")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Teacher_Class");

                    b.Navigation("GetClass");

                    b.Navigation("GetUser");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.User", b =>
                {
                    b.HasOne("CourseSignupSystem.Models.Role", "GetRole")
                        .WithMany("Co_User")
                        .HasForeignKey("RoleId");

                    b.Navigation("GetRole");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Class", b =>
                {
                    b.Navigation("Co_Class_Program");

                    b.Navigation("Co_Class_Room");

                    b.Navigation("Co_Salary");

                    b.Navigation("Co_Student_Class");

                    b.Navigation("Co_Teacher_Class");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Department", b =>
                {
                    b.Navigation("Co_Faculties");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Faculty", b =>
                {
                    b.Navigation("Co_Subject");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Fee", b =>
                {
                    b.Navigation("Co_Class");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.FeeType", b =>
                {
                    b.Navigation("Co_Fee");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Permission", b =>
                {
                    b.Navigation("Co_Role_Permission");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Programs", b =>
                {
                    b.Navigation("Co_Class_Prgram");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Role", b =>
                {
                    b.Navigation("Co_Role_permission");

                    b.Navigation("Co_User");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Room", b =>
                {
                    b.Navigation("Co_Class_Room");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Schedule", b =>
                {
                    b.Navigation("Co_Class");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Score", b =>
                {
                    b.Navigation("Co_Student_Score");

                    b.Navigation("Co_Subject_Score");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Subject", b =>
                {
                    b.Navigation("Co_Class");

                    b.Navigation("Co_Student_Score");

                    b.Navigation("Co_Subject_Score");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.User", b =>
                {
                    b.Navigation("Co_Salary");

                    b.Navigation("Co_Student");

                    b.Navigation("Co_Student_Class");

                    b.Navigation("Co_Student_Score");

                    b.Navigation("Co_Teacher");

                    b.Navigation("Co_Teacher_Class");
                });
#pragma warning restore 612, 618
        }
    }
}
