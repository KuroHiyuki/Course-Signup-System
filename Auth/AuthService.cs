using AutoMapper;
using CourseSignupSystem.Auth.SignIn;
using CourseSignupSystem.Auth.SignUp;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;

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
        public async Task<List<ResUserData>> SignInAsync(ReqSignIn model)
        {
            var res = new ResUserData();
            var user = await _context.Users!.FirstOrDefaultAsync(dt => dt.UserName == model.Username);
            if (user == null)
            {
                throw new Exception();
            }
            else
            {
                if(user.UserPassword != model.Password) { throw new Exception(); }
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

        public async Task SignUpAsync(ReqSignUp model)
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
    }
}
