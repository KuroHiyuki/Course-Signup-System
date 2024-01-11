using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Mark
    {
        [Key]
        public string? MarkId { get; set; }
        public string? MarkName { get; set;}
    }
}
