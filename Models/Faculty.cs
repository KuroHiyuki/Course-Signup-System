using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Faculty
    {
        [Key]
        public string? FacultyId { get; set; }
        public string? FacultyName { get; set; }
        public string? Note { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
