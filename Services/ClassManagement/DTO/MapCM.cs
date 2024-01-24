using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.ClassManagement.DTO
{
    public class MapCM:Profile
    {
        public MapCM()
        {
            CreateMap<Class, ClassListDTO>()
                .ForMember(des => des.ProgramName, act => act.MapFrom(src => src.Co_Class_Program.FirstOrDefault(cp => cp.ClassId == src.ClassId)!.GetProgram!.ProgramName))
                .ForMember(des => des.FeeCost, act => act.MapFrom(src => src.GetFee!.FeeCost))
                .ForMember(des => des.DepartmentName, act => act.MapFrom(src => src.GetDepartment!.DepartmentName))
                .ForMember(des => des.NumberOfStudent, act => act.MapFrom(src => src.Co_Student_Class.Count(cr => cr.ClassId==src.ClassId)))
                .ReverseMap();
            CreateMap<Class, RUDClassDTO>().ReverseMap();
            CreateMap<User,StudentOfClassListDTO>()
                .ForMember(des => des.IsPayment, act => act.MapFrom(src => src.Co_Student_Class.FirstOrDefault( fi=> fi.UserId == src.UserId)!.IsPayment))
                .ReverseMap();
        }
    }
}
