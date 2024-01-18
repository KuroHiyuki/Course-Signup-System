using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Auth.SignIn
{
    public class ReqSignIn
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public bool IsTeacher { get; set; } = false;
    }
}
