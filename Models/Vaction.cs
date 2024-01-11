using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Vaction
    {
        [Key]
        public string? VacationId { get; set; }
        public string? VacationName { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreatedAt { get; set; } = default(DateTime?);
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
