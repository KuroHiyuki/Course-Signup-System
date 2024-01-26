using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.RevenueManagement.DTO
{
    public class TeacherSalaryListDTO
    {
        public string? UserId { get; set; }
        [NotNull]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Image { get; set; }
        [NotNull, EmailAddress]
        public string? Email { get; set; }
        public string? NumberPhone { get; set; }
        public int TotalSalary { get; set; }
        public bool? IsPayment { get; set; }
    }
}
