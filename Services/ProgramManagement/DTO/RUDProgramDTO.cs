namespace CourseSignupSystem.Services.ProgramManagement.DTO
{
    public class RUDProgramDTO
    {
        public string? ProgramId { get; set; }
        public string? ProgramName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
    }
}
