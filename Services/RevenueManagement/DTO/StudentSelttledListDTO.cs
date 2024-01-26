using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.RevenueManagement.DTO
{
    public class StudentSelttledListDTO
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
        public DateTime BirthDate { get; set; }
        public string? ParentName { get; set; }
        public string? ClassId { get; set; }
    }
}
