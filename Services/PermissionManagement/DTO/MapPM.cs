using AutoMapper;
using CourseSignupSystem.Models;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;

namespace CourseSignupSystem.Services.PermissionManagement.DTO
{
    public class MapPM: Profile
    {
        public MapPM()
        {
            CreateMap<User,AdminListDTO>()
                .ForMember(des => des.RoleName , act => act.MapFrom(src => src.GetRole!.RoleName));
            CreateMap<User,RUDAdminDTO>().ReverseMap();
            CreateMap<Permission, RolePermissionDTO>()
                .ForMember(des => des.RoleId, act => act.MapFrom(src => src.Co_Role_Permission.FirstOrDefault(ds => ds.PermissionId == src.PermissionId)==null? null: src.Co_Role_Permission.FirstOrDefault(ds => ds.PermissionId == src.PermissionId)!.RoleId))
                .ForMember(des => des.IsTrue, act => act.MapFrom(src => src.Co_Role_Permission.FirstOrDefault(ds => ds.PermissionId == src.PermissionId) != null))
                .ReverseMap();
            CreateMap<Role_Permission, RUDRolePermissionDTO>().ReverseMap();
            CreateMap<Role,RoleListDTO>().ReverseMap();
        }
    }
}
