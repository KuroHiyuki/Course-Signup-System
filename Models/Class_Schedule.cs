namespace CourseSignupSystem.Models
{
    public class Class_Schedule
    {
        public string? ClassId { get; set; }
        public string? ScheduleId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual Class? GetClass { get; set; }
        public virtual Schedule? GetSchedule { get; set; }
    }
}
