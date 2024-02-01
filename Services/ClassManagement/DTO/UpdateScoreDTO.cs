namespace CourseSignupSystem.Services.ClassManagement.DTO
{
    public class UpdateScoreDTO
    {
        public decimal? Score { get; set; }
        public bool? IsTerminal { get; set; } = false;
    }
}
