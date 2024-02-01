using AutoMapper;
using CourseSignupSystem.Models;
using CourseSignupSystem.Services.TeacherManagement.DTO;

namespace CourseSignupSystem.Services.StudentManagement.DTOs
{
    public class MapStudentM: Profile
    {
        public MapStudentM() 
        {
            CreateMap<User, StudentListDTO>()
                .ForMember(des => des.ParentName, act => act.MapFrom(src => src.Co_Student!.ParentName))
                .ReverseMap();
            CreateMap<User, RUDStudentDTO>().ReverseMap();
            CreateMap<Student_Class, EnrollmentDTO>().ReverseMap();
            CreateMap<Class_Schedule, StudentScheduleDTO>()
                .ForMember(des => des.ScheduleId, act => act.MapFrom(src => src.GetSchedule!.ScheduleId))
                .ForMember(des => des.ScheduleName, act => act.MapFrom(src => src.GetSchedule!.ScheduleName))
                .ForMember(des => des.TimeStart, act => act.MapFrom(src => src.GetSchedule!.TimeStart))
                .ForMember(des => des.Duration, act => act.MapFrom(src => src.GetSchedule!.Duration));
        }
    }
}
