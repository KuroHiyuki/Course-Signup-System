using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Student
    {
        [Key]
        public string? UserId { get; set; }
        public string? ParentName { get; set; }
        public string? ParentNumberPhone { get; set; }
        public string? ParentEmail { get; set; }
        public virtual User? GetUser {  get; set; }
    }
}
