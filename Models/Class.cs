using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Class
    {
        [Key]
        public string? ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? Description { get; set; }
        public string? TuitionFee { get; set; }
        public string? Discount { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? ScheduleId { get; set; } 
    }
}
