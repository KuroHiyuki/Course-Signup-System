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
            CreateMap<Class_Schedule, ScheduleTeacherDTO>()
                .ForMember(des => des.ScheduleId, act => act.MapFrom(src => src.GetSchedule!.ScheduleId))
                .ForMember(des => des.ScheduleName, act => act.MapFrom(src => src.GetSchedule!.ScheduleName))
                .ForMember(des => des.TimeStart, act => act.MapFrom(src => src.GetSchedule!.TimeStart))
                .ForMember(des => des.Duration, act => act.MapFrom(src => src.GetSchedule!.Duration));
        }
    }
}
