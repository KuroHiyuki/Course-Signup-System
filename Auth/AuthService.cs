using AutoMapper;
using CourseSignupSystem.Auth.ForgotPassword;
using CourseSignupSystem.Auth.SignIn;
using CourseSignupSystem.Auth.SignUp;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace CourseSignupSystem.Auth
{
    public class AuthService : IAuthService
    {
        private readonly CourseContext _context;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public AuthService(CourseContext context, IConfiguration configuration, IMapper mapper)
        {
            _context = context;
            _config = configuration;
            _mapper = mapper;
        }
        //private async Task SendResetPasswordEmail(string toEmail, string token)
        //{
        //    var apiKey = _config["SendGrid:ApiKey"];
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress("mashiro.nguyen@gmail.com", "Course Sign Up System");
        //    var to = new EmailAddress(toEmail);
        //    var subject = "Reset Your Password";
        //    var htmlContent = $"<p>Please click <a href=\"http://your-app-url/reset-password?token={token}\">here</a> to reset your password.</p>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, null, htmlContent);
        //    await client.SendEmailAsync(msg);
        //}
        public async Task<string> ForgotPasswordAsync(string Email)
        {
            try
            {
                var user = await _context.Users!.FirstOrDefaultAsync(u => u.Email== Email) ?? throw new Exception("Not Found");
                var token = Guid.NewGuid().ToString();
                user.ResetToken = token;
                user.ResetTokenExpiration = DateTime.Now.AddMinutes(15);
                _context.Update(user);
                await _context.SaveChangesAsync();
                return token;
                //await SendResetPasswordEmail(user.Email, token);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task ResetPasswordAsync(ResetPassword model)
        {
            try
            {
                var user = await _context.Users!
                    .FirstOrDefaultAsync(u => u.Email == model.Email 
                    && u.ResetToken == model.Token 
                    && u.ResetTokenExpiration > DateTime.Now) ?? throw new Exception("Invalid token or token expired");
                if( model.NewPassword != model.ConfirmPassword )
                {
                    throw new Exception("Password mismatch");
                }
                user.UserPassword = model.NewPassword;
                user.ResetToken = null;
                user.ResetTokenExpiration = null;
                _context.Update(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ResUserData>> SignInAsync(ReqSignIn model)
        {
            try
            {
                var res = new ResUserData();
                var user = await _context.Users!.FirstOrDefaultAsync(dt => dt.UserName == model.Username);
                if (user == null)
                {
                    throw new Exception();
                }
                else
                {
                    if (user.UserPassword != model.Password) { throw new Exception("Invalid Password"); }
                }
                var role = await _context.Roles!.FindAsync(user.RoleId);
                var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,model.Username!),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, role!.RoleName!)
            };

                var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _config["JWT:ValidIssuer"],
                    audience: _config["JWT:ValidAudience"],
                    expires: DateTime.Now.AddMinutes(20),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
                );
                res.UserName = model.Username;
                res.JWT_Token = new JwtSecurityTokenHandler().WriteToken(token);
                res.Role = role.RoleName!;

                return new List<ResUserData> { res };
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task SignUpAsync(ReqSignUp model)
        {
            try
            {
                var role = await _context.Roles!.FirstOrDefaultAsync(dt => dt.RoleName == "Học viên");
                var user = _mapper.Map<User>(model);
                user.UserId = Guid.NewGuid().ToString();
                user.UserName = model.Email;
                user.UserPassword = model.Password;
                user.RoleId = role!.RoleId;
                _context.Users!.Add(user);
                _context.SaveChanges();
                var Student = new Student
                {
                    UserId = user.UserId,
                    ParentName = model.ParentName
                };
                _context.Students!.Add(Student);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
