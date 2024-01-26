using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.RevenueManagement.DTO
{
    public class MapRM:Profile
    {
        public MapRM()
        {
            CreateMap<Student_Class, RevenueListDTO>()
                .ForMember(des => des.UserId, act => act.MapFrom(src => src.UserId))
                .ForMember(des => des.StudentName, act => act.MapFrom(src => src.GetUser!.FirstName + " " +src.GetUser.LastName))
                .ForMember(des => des.ClassId, act => act.MapFrom(src => src.ClassId))
                .ForMember(des => des.FeeCost, act => act.MapFrom(src => src.GetClass!.GetFee!.FeeCost))
                .ReverseMap();
            CreateMap<User, StudentSelttledListDTO>()
                .ForMember(des => des.ParentName, act => act.MapFrom(src => src.Co_Student!.ParentName))
                .ForMember(des => des.ClassId, act => act.MapFrom(src => src.Co_Student_Class.FirstOrDefault(ds => ds.UserId == src.UserId)!.ClassId));
            CreateMap<User, TeacherSalaryListDTO>()
                .ForMember(des => des.IsPayment, act => act.MapFrom(src => src.Co_Teacher_Class.FirstOrDefault(ds => ds.UserId == src.UserId)!.IsPayment))
                .ForMember(des => des.TotalSalary, act => act.MapFrom(src => src.Co_Salary
                        .Where(ds => ds.UserId == src.UserId)
                        .Sum(ds => ds.GetClass!.GetFee!.FeeCost * ds.RateOfCharge / 100 + ds.Allowance)));
            CreateMap<User, PaySlipDTO>().ReverseMap();
            CreateMap<Salary, RUDPaySlipDTO>().ReverseMap();
        }
    }
}
