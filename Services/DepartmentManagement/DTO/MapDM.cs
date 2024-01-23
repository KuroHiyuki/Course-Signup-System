using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.DepartmentManagement.DTO
{
    public class MapDM:Profile
    {
        public MapDM()
        {
            CreateMap<Department, DepartmentListDTO>().ReverseMap();
            CreateMap<Department, RUDDepartmentDTO>().ReverseMap();
        }
    }
}
