using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Subject
    {
        public Subject()
        {
            Co_Class = new HashSet<Class>();
            Co_Subject_Score = new HashSet<Subject_Score>();
        }
        [Key]
        public string? SubjectId { get; set; }
        public string? SubjectName { get; set;}
        public string? SubjectNote { get; set;}
        public DateTime CreatedDate { get; set; }
        public string? FacultyId { get; set; }
        public virtual Faculty? GetFaculty { get; set; }
        public virtual ICollection<Class> Co_Class { get; set; }
        public virtual ICollection<Subject_Score>? Co_Subject_Score { get; set; }
        public virtual ICollection<Student_Score>? Co_Student_Score { get; set; }
    }
}
