using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Department
    {
        public Department()
        {
            Co_Faculties = new HashSet<Faculty>();
            Co_Class = new HashSet<Class>();
        }
        [Key]
        public string? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Faculty> Co_Faculties { get; set; }
        public virtual ICollection<Class> Co_Class { get; set; }

    }
}
