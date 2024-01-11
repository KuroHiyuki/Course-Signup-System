using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Role
    {
        [Key]
        public string? RoleId { get; set; }
        public string? RoleName { get; set;}

    }
}
