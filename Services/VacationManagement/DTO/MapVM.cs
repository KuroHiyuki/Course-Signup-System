using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.VacationManagement.DTO
{
    public class MapVM:Profile
    {
        public MapVM() 
        {
            CreateMap<Vaction,VacationListDTO>().ReverseMap();
            CreateMap<Vaction, RUDVacationDTO>().ReverseMap();
        }
    }
}
