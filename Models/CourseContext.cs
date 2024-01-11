using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System;

namespace CourseSignupSystem.Models
{
    public class CourseContext:DbContext
    {
        public CourseContext()
        {
        }

        public CourseContext(DbContextOptions<CourseContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=KURO;Initial Catalog=CourseDb;Integrated Security=True;User Instance=False");
            }
        }
        #region Dbcontext Enities
        public virtual DbSet<Administator>? Administators { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Class>? Class { get; set; }
        public virtual DbSet<Department>? Departments { get; set; }
        public virtual DbSet<Faculty>? Faculties { get; set; }
        public virtual DbSet<Mark>? Marks { get; set; }
        public virtual DbSet<Permission>? Permissions { get; set; }
        public virtual DbSet<Program>? Programs { get; set; }
        public virtual DbSet<Role>? Roles { get; set; }
        public virtual DbSet<Room>? Rooms { get; set; }
        public virtual DbSet<Schedule>? Schedules { get; set; }
        public virtual DbSet<Student>? Students { get; set; }
        public virtual DbSet<Subject>? Subjects { get; set; }
        public virtual DbSet<Teacher>? Teachers { get; set; }
        public virtual DbSet<Vaction>? Vactions { get; set; }

        #endregion
    }
}
