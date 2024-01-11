using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Department
    {
        [Key]
        public string? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentStatus { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
