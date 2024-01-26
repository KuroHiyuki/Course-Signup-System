using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.RevenueManagement.DTO
{
    public class PaySlipDTO
    {
        public string? UserId { get; set; }
        [NotNull]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? RoleName { get; set; }
        public int? RateOfCharge { get; set; }
        public int? Allowance { get; set; }
        public string? Note { get; set; }
        public int Total { get; set; }
    }
}
