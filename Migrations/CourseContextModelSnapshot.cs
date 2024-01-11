﻿// <auto-generated />
using System;
using CourseSignupSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseSignupSystem.Migrations
{
    [DbContext(typeof(CourseContext))]
    partial class CourseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseSignupSystem.Models.Administator", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Administators");
                });

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

                    b.Property<string>("Discount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ScheduleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TuitionFee")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Class");
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

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultyId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Mark", b =>
                {
                    b.Property<string>("MarkId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MarkName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarkId");

                    b.ToTable("Marks");
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

            modelBuilder.Entity("CourseSignupSystem.Models.Program", b =>
                {
                    b.Property<string>("ProgramId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProgramName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Term")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgramId");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Room", b =>
                {
                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Schedule", b =>
                {
                    b.Property<string>("ScheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Duration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ScheduleName")
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TimeOnly")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Student", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Subject", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectNote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CourseSignupSystem.Models.Teacher", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MainSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Teachers");
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

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

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
#pragma warning restore 612, 618
        }
    }
}
