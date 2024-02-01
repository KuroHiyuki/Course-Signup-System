using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Student_Score
    {
        [Key]
        public string? MarkId { get; set; }
        public string? UserId { get; set; }
        public string? SubjectId { get; set; }
        public string? ScoreId { get; set; }
        public decimal Score { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public bool? IsTerminal { get; set; } = false;
        public virtual User? GetUser { get; set; }
        public virtual Score? GetScore { get; set; }
        public virtual Subject? GetSubject { get; set; }
    }
}
