using CourseSignupSystem.Enumerables;

namespace CourseSignupSystem.Services.ScheduleManagement.DTO
{
    public class RUDScheduleDTO
    {
        public string? ClassId { get; set; }
        public string? SubjectId { get; set; }
        public string? RoomId { get; set; }
        public string? UserId { get; set; }
        public string? WeekDay { get; set; }
        public decimal? Duration { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
