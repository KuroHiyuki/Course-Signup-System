namespace CourseSignupSystem.Services.ScoreManagement.DTO
{
    public class RUDSubjectOfScoreDTO
    {
        public string? ProgramId { get; set; }
        public string? SubjectId { get; set; }
        public string? ScoreId { get; set; }
        public int ScoreColumn { get; set; }
        public int RequiredColumn { get; set; }
    }
}
