using System.Diagnostics.CodeAnalysis;

namespace CourseSignupSystem.Services.RevenueManagement.DTO
{
    public class RUDPaySlipDTO
    {
        public string? UserId { get; set; }
        [NotNull]
        public int? RateOfCharge { get; set; }
        public int? Allowance { get; set; }
        public string? Note { get; set; }
        public int Total {  get; set; }
    }
}
