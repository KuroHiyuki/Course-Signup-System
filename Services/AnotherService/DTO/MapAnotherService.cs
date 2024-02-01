using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.AnotherService.DTO
{
    public class MapAnotherService:Profile
    {
        public MapAnotherService()
        {
            CreateMap<Room, ListRoomDTO>().ReverseMap();
            CreateMap<Room, RUDRoomDTO>().ReverseMap();
        }
    }
}
