using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System;
using CourseSignupSystem.Models;
using System.Text.Json;
using System.Xml;
using Microsoft.Extensions.Configuration;

namespace CourseSignupSystem.ContextData
{
    public class CourseContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public CourseContext(DbContextOptions<CourseContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        #region Dbcontext Enities
        public virtual DbSet<Class>? Classes { get; set; }
        public virtual DbSet<Class_Program>? Class_Programs { get; set; }
        public virtual DbSet<Class_Room>? Class_Rooms { get; set; }
        public virtual DbSet<Department>? Departments { get; set; }
        public virtual DbSet<Faculty>? Faculties { get; set; }
        public virtual DbSet<Fee>? Fees { get; set; }
        public virtual DbSet<FeeType>? FeeTypes { get; set; }
        public virtual DbSet<Permission>? Permissions { get; set; }
        public virtual DbSet<Programs>? Programs { get; set; }
        public virtual DbSet<Role>? Roles { get; set; }
        public virtual DbSet<Role_Permission>? Role_Permissions { get; set; }
        public virtual DbSet<Room>? Rooms { get; set; }
        public virtual DbSet<Salary>? Salaries { get; set; }
        public virtual DbSet<Schedule>? Schedules { get; set; }
        public virtual DbSet<Student>? Students { get; set; }
        public virtual DbSet<Student_Class>? Student_Classes { get; set; }
        public virtual DbSet<Student_Score>? Student_Scores { get; set; }
        public virtual DbSet<Subject>? Subjects { get; set; }
        public virtual DbSet<Subject_Score>? Subject_Scores { get; set; }
        public virtual DbSet<Teacher>? Teachers { get; set; }
        public virtual DbSet<Teacher_Class>? Teacher_Classes { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Vaction>? Vactions { get; set; }

        #endregion

        #region FluentAPI
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var seederPath = _configuration.GetValue<string>("SeederPath");
            var jsonData = System.IO.File.ReadAllText($"{seederPath}Seeders\\Roles.json");
            //var jsonData = System.IO.File.ReadAllText("C:\\Disk C\\Skill\\Coding\\Dot NET\\CourseSignupSystem\\Seeders\\Roles.json");
            //var jsonData = System.IO.File.ReadAllText(Path.Combine(seederPath, "Roles.json"));
            var roleJson = JsonSerializer.Deserialize<List<Role>>(jsonData);

            modelBuilder.Entity<Class>(Entity =>
            {
                Entity.ToTable("CLASS");
                Entity.HasKey(k => k.ClassId).HasName("ClassId");
            });
            modelBuilder.Entity<Class_Program>(Entity =>
            {
                Entity.ToTable("R_Class_Program");
                Entity.HasKey(k => new { k.ProgramId, k.ClassId });

                Entity.HasOne(d => d.GetClass)
                     .WithMany(p => p.Co_Class_Program)
                     .HasForeignKey(d => d.ClassId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Class_Program");

                Entity.HasOne(d => d.GetProgram)
                     .WithMany(p => p.Co_Class_Prgram)
                     .HasForeignKey(d => d.ProgramId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Program_Class");
            });
            modelBuilder.Entity<Class_Room>(Entity =>
            {
                Entity.ToTable("R_Class_Room");
                Entity.HasKey(k => new { k.RoomId, k.ClassId });

                Entity.HasOne(d => d.GetClass)
                     .WithMany(p => p.Co_Class_Room)
                     .HasForeignKey(d => d.ClassId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Class_Room");

                Entity.HasOne(d => d.GetRoom)
                     .WithMany(p => p.Co_Class_Room)
                     .HasForeignKey(d => d.RoomId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Room_Class");
            });
            modelBuilder.Entity<Role_Permission>(Entity =>
            {
                Entity.ToTable("R_Role_Permission");
                Entity.HasKey(k => new { k.RoleId, k.PermissionId });

                Entity.HasOne(d => d.GetRole)
                     .WithMany(p => p.Co_Role_permission)
                     .HasForeignKey(d => d.RoleId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Role_Permission");

                Entity.HasOne(d => d.GetPermission)
                     .WithMany(p => p.Co_Role_Permission)
                     .HasForeignKey(d => d.PermissionId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Permission_Role");
            });
            modelBuilder.Entity<Salary>(Entity =>
            {
                Entity.ToTable("R_Salary");
                Entity.HasKey(k => new { k.UserId, k.ClassId });

                Entity.HasOne(d => d.GetUser)
                     .WithMany(p => p.Co_Salary)
                     .HasForeignKey(d => d.UserId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_User_Salary");

                Entity.HasOne(d => d.GetClass)
                     .WithMany(p => p.Co_Salary)
                     .HasForeignKey(d => d.ClassId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Class_Salary");
            });
            modelBuilder.Entity<Student_Class>(Entity =>
            {
                Entity.ToTable("R_Student_Class");
                Entity.HasKey(k => new { k.UserId, k.ClassId });

                Entity.HasOne(d => d.GetUser)
                     .WithMany(p => p.Co_Student_Class)
                     .HasForeignKey(d => d.UserId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Student_Class");

                Entity.HasOne(d => d.GetClass)
                     .WithMany(p => p.Co_Student_Class)
                     .HasForeignKey(d => d.ClassId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Class_Student");
            });
            modelBuilder.Entity<Student_Score>(Entity =>
            {
                Entity.ToTable("R_Student_Score");
                Entity.HasKey(k => new { k.UserId, k.SubjectId });

                Entity.HasOne(d => d.GetUser)
                     .WithMany(p => p.Co_Student_Score)
                     .HasForeignKey(d => d.UserId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Student_Score");

                Entity.HasOne(d => d.GetSubject)
                     .WithMany(p => p.Co_Student_Score)
                     .HasForeignKey(d => d.SubjectId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Subject_Student");
                Entity.HasOne(d => d.GetScore)
                     .WithMany(p => p.Co_Student_Score)
                     .HasForeignKey(d => d.ScoreId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Score_Student");
            });
            modelBuilder.Entity<Subject_Score>(Entity =>
            {
                Entity.ToTable("R_Subject_Score");
                Entity.HasKey(k => new { k.SubjectId, k.ScoreId });

                Entity.HasOne(d => d.GetSubject)
                     .WithMany(p => p.Co_Subject_Score)
                     .HasForeignKey(d => d.SubjectId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Subject_Score");

                Entity.HasOne(d => d.GetScore)
                     .WithMany(p => p.Co_Subject_Score)
                     .HasForeignKey(d => d.ScoreId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Score_Subject");
            });
            modelBuilder.Entity<Teacher_Class>(Entity =>
            {
                Entity.ToTable("R_Teacher_Class");
                Entity.HasKey(k => new { k.UserId, k.ClassId });

                Entity.HasOne(d => d.GetUser)
                     .WithMany(p => p.Co_Teacher_Class)
                     .HasForeignKey(d => d.UserId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Teacher_Class");

                Entity.HasOne(d => d.GetClass)
                     .WithMany(p => p.Co_Teacher_Class)
                     .HasForeignKey(d => d.ClassId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Class_Teacher");
            });
            modelBuilder.Entity<Student>(Entity =>
            {
                Entity.HasOne(d => d.GetUser)
                     .WithMany(p => p.Co_Student)
                     .HasForeignKey(d => d.UserId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Student");
            });
            modelBuilder.Entity<Teacher>(Entity =>
            {
                Entity.HasOne(d => d.GetUser)
                     .WithMany(p => p.Co_Teacher)
                     .HasForeignKey(d => d.UserId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Teacher");
            });

            modelBuilder.Entity<Role>().HasData(roleJson!);
        }
        #endregion
    }
}
