using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Student
    {
        [Key]
        public string? UserId { get; set; }
        public string? ParentName { get; set; }
    }
}
