using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.ScheduleManagement.DTO
{
    public class MapSchedule:Profile
    {
        public MapSchedule() 
        {
            CreateMap<User, ScheduleToTeacherDTO>()
                .ForMember(des => des.SubjectName, act => act.MapFrom(src => src.Co_Teacher_Class.FirstOrDefault(tc =>tc.UserId == src.UserId)!.GetClass!.Co_Class_Subject.FirstOrDefault(cs => cs.ClassId == src.Co_Teacher_Class.FirstOrDefault(tc => tc.UserId == src.UserId)!.GetClass!.ClassId)!.GetSubject!.SubjectName))
                .ForMember(des => des.ClassName, act => act.MapFrom(src => src.Co_Teacher_Class.FirstOrDefault(tc => tc.UserId == src.UserId)!.GetClass!.ClassName))
                .ForMember(des => des.StartDate, act => act.MapFrom(src => src.Co_Teacher_Class.FirstOrDefault(tc => tc.UserId == src.UserId)!.GetClass!.StartedDate))
                .ForMember(des => des.EndDate, act => act.MapFrom(src => src.Co_Teacher_Class.FirstOrDefault(tc => tc.UserId == src.UserId)!.GetClass!.EndDate))
                .ReverseMap();
        }
    }
}
