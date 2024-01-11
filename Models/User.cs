using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public enum Sex
    {
        Nonbinary = 0, Male = 1,Female = 2,
    }
    public class User
    {
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
    }
}
