using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public enum Day
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
    }
    public class Schedule
    {
        [Key]
        public string? ScheduleId { get; set; }
        public Day ScheduleName { get; set; }
        public decimal? Duration { get; set; }
        public DateTime? TimeOnly { get; set; } 
        public string? SubjectId { get; set; }


    }
}
