using CourseSignupSystem.Enumerables;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.TeacherManagement.DTO
{
    public class RUDTeacherDTO
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
        public string? TaxCode { get; set; }
        public string? MainSubject { get; set; }
        public string? SubSubject { get; set; }
        public DateTime BirthDate { get; set; }
        public string? UserPassword { get; set; }
    }
}
