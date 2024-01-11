using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Subject
    {
        [Key]
        public string? SubjectId { get; set; }
        public string? SubjectName { get; set;}
        public string? SubjectNote { get; set;}
        public DateTime CreatedDate { get; set; }

    }
}
