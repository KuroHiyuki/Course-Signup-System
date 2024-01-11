using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Program
    {
        [Key]
        public string? ProgramId { get; set; }
        public string? ProgramName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Term {  get; set; }

    }
}
