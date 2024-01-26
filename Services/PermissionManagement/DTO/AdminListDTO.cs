using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.PermissionManagement.DTO
{
    public class AdminListDTO
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        [NotNull, EmailAddress]
        public string? Email { get; set; }
        public string? RoleName { get; set; }
    }
}
