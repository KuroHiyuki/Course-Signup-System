using AutoMapper;
using CourseSignupSystem.Models;

namespace CourseSignupSystem.Services.ScoreManagement.DTO
{
    public class MapScore_M:Profile
    {
        public MapScore_M() 
        {
            CreateMap<Subject_Score, SubjectofScoreListDTO>()
                .ForMember(des => des.ProgramName, act => act.MapFrom(src => src.GetSubject!.GetPrograms!.ProgramName))
                .ForMember(des => des.ScoreName, act => act.MapFrom(src => src.GetScore!.ScoreName))
                .ForMember(des => des.SubjectName, act => act.MapFrom(src => src.GetSubject!.SubjectName));
            CreateMap<Subject_Score, RUDSubjectOfScoreDTO>().ReverseMap();
            CreateMap<Score, ScoreTypeListDTO>().ReverseMap();
            CreateMap<Score, RUDScoreTypeDTO>().ReverseMap();
        }
    }
}
