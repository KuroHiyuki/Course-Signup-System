using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.TeacherManagement.DTO
{
    public class MapTM:Profile
    {
        public MapTM()
        {
            CreateMap<User, RUDTeacherDTO>().ReverseMap();
            CreateMap<User, TeacherListDTO>().ReverseMap();
        }
    }
}
