using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public enum Sex
    {
        Nonbinary = 0, Male = 1,Female = 2,
    }
    public class User
    {
        public User()
        {
            Co_Salary = new HashSet<Salary>();
            Co_Student = new HashSet<Student>();
            Co_Student_Class = new HashSet<Student_Class>();
            Co_Student_Score = new HashSet<Student_Score>();
            Co_Teacher = new HashSet<Teacher>();
            Co_Teacher_Class = new HashSet<Teacher_Class>();
        }
        [Key]
        public string? UserId { get; set; }
        public string? UserName { get; set;}
        public string? UserPassword { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Image {  get; set; }
        public string? Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Address { get; set; }
        public string? NumberPhone { get; set; }
        public Sex Sex { get; set; } = Sex.Nonbinary;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string? RoleId { get; set; }
        public virtual Role? GetRole { get; set; }
        public virtual ICollection<Salary> Co_Salary { get; set; }
        public virtual ICollection<Student> Co_Student { get; set; }
        public virtual ICollection<Student_Class> Co_Student_Class { get; set; }
        public virtual ICollection<Student_Score> Co_Student_Score { get; set; }
        public virtual ICollection<Teacher> Co_Teacher { get; set; }
        public virtual ICollection<Teacher_Class> Co_Teacher_Class { get; set; }
    }
}
