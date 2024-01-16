using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Faculty
    {
        public Faculty()
        {
            Co_Subject = new HashSet<Subject>();
        }
        [Key]
        public string? FacultyId { get; set; }
        public string? FacultyName { get; set; }
        public string? Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? DepartmentId { get; set; }
        public virtual Department? GetDepartment {  get; set; }
        public virtual ICollection<Subject> Co_Subject { get; set; }

    }
}
