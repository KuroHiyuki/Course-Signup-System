using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Services.ClassManagement.DTO
{
    public class StudentOfClassListDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [EmailAddress]
        public string? Email {  get; set; }
        public string? NumberPhone { get; set; }
        public bool? IsPayment { get; set; } = false;
    }
}
