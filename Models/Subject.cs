using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Subject
    {
        public Subject()
        {
            _Class = new HashSet<Class>();
            _Subject_Score = new HashSet<Subject_Score>();
        }
        [Key]
        public string? SubjectId { get; set; }
        public string? SubjectName { get; set;}
        public string? SubjectNote { get; set;}
        public DateTime CreatedDate { get; set; }
        public string? FacultyId { get; set; }
        public virtual Faculty? GetFaculty { get; set; }
        public virtual ICollection<Class> _Class { get; set; }
        public virtual ICollection<Subject_Score> _Subject_Score { get; set; }

    }
}
