using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.ClassManagement.DTO
{
    public class ListScoreOFStudentDTO
    {
        public string? StudentName { get; set; }
        public string? ScoreName { get; set; }
        public string? MarkId { get; set; }
        public decimal Score { get; set; }
    }
}
