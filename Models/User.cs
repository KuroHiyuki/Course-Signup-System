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
            _Salary = new HashSet<Salary>();
            _Student = new HashSet<Student>();
            _Student_Class = new HashSet<Student_Class>();
            _Student_Score = new HashSet<Student_Score>();
            _Teacher = new HashSet<Teacher>();
            _Teacher_Class = new HashSet<Teacher_Class>();
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
        public virtual ICollection<Salary> _Salary { get; set; }
        public virtual ICollection<Student> _Student { get; set; }
        public virtual ICollection<Student_Class> _Student_Class { get; set; }
        public virtual ICollection<Student_Score> _Student_Score { get; set; }
        public virtual ICollection<Teacher> _Teacher { get; set; }
        public virtual ICollection<Teacher_Class> _Teacher_Class { get; set; }
    }
}
