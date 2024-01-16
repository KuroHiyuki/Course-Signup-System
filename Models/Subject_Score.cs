namespace CourseSignupSystem.Models
{
    public class Subject_Score
    {
        public string? SubjectId { get; set; }
        public string? ScoreId { get; set; }
        public DateTime? UpdateDate { get; set; } = DateTime.Now;
        public virtual Subject? GetSubject { get; set; }
        public virtual Score? GetScore { get; set; }
    }
}
