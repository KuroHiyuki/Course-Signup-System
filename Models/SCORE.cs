using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Score
    {
        public Score() 
        {
            Co_Subject_Score = new HashSet<Subject_Score>();
            Co_Student_Score = new HashSet<Student_Score>();
        }
        [Key]
        public string? ScoreId { get; set; }
        public string? ScoreName { get; set; }
        public int ScoreColumn { get; set; }
        public int RequiredColumn { get; set; }
        public int MultiplierScore { get; set; }
        public virtual ICollection<Subject_Score> Co_Subject_Score { get; set; }
        public virtual ICollection<Student_Score> Co_Student_Score { get; set; }

    }
}
