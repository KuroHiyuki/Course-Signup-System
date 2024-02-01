using CourseSignupSystem.Enumerables;

namespace CourseSignupSystem.Services.TeacherManagement.DTO
{
    public class ScheduleTeacherDTO
    {
        public string? ScheduleId { get; set; }
        public Day ScheduleName { get; set; }
        public decimal? Duration { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
