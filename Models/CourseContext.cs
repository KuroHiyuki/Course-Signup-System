using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System;

namespace CourseSignupSystem.Models
{
    public class CourseContext:DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options)
            : base(options)
        {
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
        public virtual DbSet<Program>? Programs { get; set; }
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

            modelBuilder.Entity<Class>(Entity =>
            {
                Entity.ToTable("CLASS");
                Entity.HasKey(k => k.ClassId).HasName("ClassId");

            });
        }
        #endregion

    }
}
