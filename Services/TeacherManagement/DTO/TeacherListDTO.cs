using CourseSignupSystem.Enumerables;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.TeacherManagement.DTO
{
    public class TeacherListDTO
    {
        public string? UserId { get; set; }
        [NotNull]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Image { get; set; }
        [NotNull, EmailAddress]
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? NumberPhone { get; set; }
        public Sex Sex { get; set; }
    }
}
