namespace CourseSignupSystem.Services.ScheduleManagement.DTO
{
    public class ScheduleToTeacherDTO
    {
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? SubjectName { get; set; }
        public string? ClassName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
