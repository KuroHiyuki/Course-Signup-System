using CourseSignupSystem.Auth.SignIn;
using CourseSignupSystem.Auth.SignUp;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Auth
{
    public interface IAuthService
    {
        public Task SignUpAsync(ReqSignUp model);
        public Task<List<ResUserData>> SignInAsync(ReqSignIn model);
    }
}
