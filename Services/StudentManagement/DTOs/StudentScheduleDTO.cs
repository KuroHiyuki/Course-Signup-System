using CourseSignupSystem.Enumerables;

namespace CourseSignupSystem.Services.StudentManagement.DTOs
{
    public class StudentScheduleDTO
    {
        public string? ScheduleId { get; set; }
        public Day ScheduleName { get; set; }
        public decimal? Duration { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
