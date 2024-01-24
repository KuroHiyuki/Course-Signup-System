using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Subject
    {
        public Subject()
        {
            Co_Class_Subject = new HashSet<Class_Subject>();
            Co_Subject_Score = new HashSet<Subject_Score>();
        }
        [Key]
        public string? SubjectId { get; set; }
        public string? SubjectName { get; set;}
        public string? SubjectNote { get; set;}
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? FacultyId { get; set; }
        public string? ProgramId { get; set; }
        public virtual Programs? GetPrograms {  get; set; }
        public virtual Faculty? GetFaculty { get; set; }
        public virtual ICollection<Class_Subject>? Co_Class_Subject { get; set; }
        public virtual ICollection<Subject_Score>? Co_Subject_Score { get; set; }
        public virtual ICollection<Student_Score>? Co_Student_Score { get; set; }
    }
}
