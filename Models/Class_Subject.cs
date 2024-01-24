namespace CourseSignupSystem.Models
{
    public class Class_Subject
    {
        public string? ClassId { get; set; }
        public string? SubjectId { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public virtual Class? GetClass { get; set; }
        public virtual Subject? GetSubject { get; set; }
    }
}
