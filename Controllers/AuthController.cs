using CourseSignupSystem.Auth;
using CourseSignupSystem.Auth.ForgotPassword;
using CourseSignupSystem.Auth.SignIn;
using CourseSignupSystem.Auth.SignUp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _repo;
        public AuthController(IAuthService repo)
        {
            _repo = repo;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(ReqSignUp model)
        {
            await _repo.SignUpAsync(model);
            return Ok();
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(ReqSignIn model)
        {
            var result = await _repo.SignInAsync(model);
            return Ok(result);
        }
        [HttpPost("ForgotPassword/{Email}")]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            var result = await _repo.ForgotPasswordAsync(Email);
            return Ok(result);
        }
        [HttpPut("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPassword model)
        {
            await _repo.ResetPasswordAsync(model);
            return Ok();
        }
    }
}
