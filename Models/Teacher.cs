using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Teacher
    {
        [Key]
        public string? UserId { get; set; }
        public string? TaxCode { get; set; }
        public string? MainSubject { get; set; }
        public string? SubSubject { get; set; }
    }
}
