namespace CourseSignupSystem.Services.VacationManagement.DTO
{
    public class VacationListDTO
    {
        public string? VacationId { get; set; }
        public string? VacationName { get; set; }
        public string? Reason { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
