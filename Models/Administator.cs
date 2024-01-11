using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Administator
    {
        [Key]
        public string? UserId { get; set; }
        public string? RoleId { get; set; }
    }
}
