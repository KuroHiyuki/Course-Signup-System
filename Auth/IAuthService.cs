using CourseSignupSystem.Auth.SignIn;
using CourseSignupSystem.Auth.SignUp;
using CourseSignupSystem.Auth.ForgotPassword;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Auth
{
    public interface IAuthService
    {
        public Task SignUpAsync(ReqSignUp model);
        public Task<List<ResUserData>> SignInAsync(ReqSignIn model);
        public Task<string> ForgotPasswordAsync(string Email);
        public Task ResetPasswordAsync (ResetPassword model);
    }
}
