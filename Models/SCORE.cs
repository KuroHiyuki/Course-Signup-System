namespace CourseSignupSystem.Models
{
    public class Score
    {
        public Score() 
        {
            _Subject_Score = new HashSet<Subject_Score>();
            _Student_Score = new HashSet<Student_Score>();
        }
        public string? ScoreId { get; set; }
        public string? ScoreName { get; set; }
        public int ScoreColumn { get; set; }
        public int RequiredColumn { get; set; }
        public int MultiplierScore { get; set; }
        public virtual ICollection<Subject_Score> _Subject_Score { get; set; }
        public virtual ICollection<Student_Score> _Student_Score { get; set; }

    }
}
