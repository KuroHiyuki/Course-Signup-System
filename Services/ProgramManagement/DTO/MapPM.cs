using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.ProgramManagement.DTO
{
    public class MapPM:Profile
    {
        public MapPM()
        {
            CreateMap<Programs, ProgramListDTO>().ReverseMap();
            CreateMap<Programs, RUDProgramDTO>().ReverseMap();
        }
    }
}
