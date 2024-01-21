using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Auth.ForgotPassword
{
    public class ResetPassword
    {
        [EmailAddress]
        public string? Email { get; set; }
        public string? Token { get; set; }
        public string? NewPassword { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
