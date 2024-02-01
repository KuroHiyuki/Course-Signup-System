namespace CourseSignupSystem.Services.ClassManagement.DTO
{
    public class AddScoreOfStudentDTO
    {
        public string? SubjectId { get; set; }
        public string? ScoreId { get; set; }
        public string? UserId { get; set; }
        public decimal? Score { get; set; }
    }
}
