using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.SubjectManagement.DTO
{
    public class MapSubjectM:Profile
    {
        public MapSubjectM()
        {
            CreateMap<Subject, SubjectListDTO>()
                .ForMember(des => des.FacultyName, act => act.MapFrom(src => src.GetFaculty!.FacultyId))
                .ForMember(des => des.DepartmentName, act => act.MapFrom(src => src.GetFaculty!.GetDepartment!.DepartmentName))
                .ReverseMap();
            CreateMap<Subject, RUDSubjectDTO>().ReverseMap();  
        }
    }
}
