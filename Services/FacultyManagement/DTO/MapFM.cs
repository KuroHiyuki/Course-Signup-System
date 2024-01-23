using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.FacultyManagement.DTO
{
    public class MapFM: Profile
    {
        public MapFM() 
        {
            CreateMap<Faculty,FacultyListDTO>().ReverseMap();
            CreateMap<Faculty, RUDFacultyDTO>().ReverseMap();
        }
    }
}
