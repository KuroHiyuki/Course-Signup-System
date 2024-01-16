namespace CourseSignupSystem.Models
{
    public class Student_Score
    {
        public string? UserId { get; set; }
        public string? SubjectId { get; set; }
        public string? ScoreId { get; set; }
        public decimal Score { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool? IsTerminal { get; set; } = false;
        public virtual User? GetUser { get; set; }
        public virtual Score? GetScore { get; set; }
    }
}
