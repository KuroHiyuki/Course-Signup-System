using CourseSignupSystem.Services.PermissionManagement.DTO;

namespace CourseSignupSystem.Services.PermissionManagement
{
    public interface IPermissionManagementService
    {
        public Task<List<AdminListDTO>> AdminList();
        public Task AddAdmin(RUDAdminDTO model);
        public Task UpdateAdmin(string UserId, RUDAdminDTO model);
        public Task DeleteAdmin(string UserId);
        public Task<List<RoleListDTO>> RoleList();
        public Task UpdateRolePermission(string RoleId, string? PermissionId,RUDRolePermissionDTO model);
        public Task<List<RolePermissionDTO>> RolePermissionList(string RoleId);
    }
}
