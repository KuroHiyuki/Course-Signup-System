using CourseSignupSystem.Enumerables;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.StudentManagement.DTOs
{
    public class RUDStudent
    {
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Image { get; set; }
        [NotNull, EmailAddress]
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? NumberPhone { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ParentName { get; set; } = null;
        public string? UserPassword { get; set; }
        public Sex Sex { get; set; }
        public string? ClassId { get; set; }
    }
}
