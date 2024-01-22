using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.StudentManagement.DTOs
{
    public class MapperSM: Profile
    {
        public MapperSM() 
        {
            CreateMap<User, StudentListDTO>()
                .ForMember(des => des.ParentName, act => act.MapFrom(src => src.Co_Student!.ParentName))
                .ReverseMap();
            CreateMap<User, RUDStudentDTO>().ReverseMap();
            CreateMap<Student_Class, EnrollmentDTO>().ReverseMap();    
        }
    }
}
