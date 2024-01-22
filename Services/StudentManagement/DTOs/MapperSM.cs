using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.StudentManagement.DTOs
{
    public class MapperSM: Profile
    {
        public MapperSM() 
        {
            CreateMap<User, StudentListDTO>().ReverseMap();
            CreateMap<User,RUDStudent>().ReverseMap();
        }
    }
}
