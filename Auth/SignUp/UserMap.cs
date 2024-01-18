using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Auth.SignUp
{
    public class UserMap:Profile
    {
        public UserMap() 
        {
            CreateMap<User,ReqSignUp>().ReverseMap();
        }
    }
}
