using CourseSignupSystem.Services.DepartmentManagement.DTO;

namespace CourseSignupSystem.Services.DepartmentManagement
{
    public interface IDepartmentManagementService
    {
        public Task<List<DepartmentListDTO>> ListDepartmentAsync();
        public Task AddDepartmentAsync(RUDDepartmentDTO model);
        public Task UpdateDepartmentAsync(string DepartmentId, RUDDepartmentDTO model);
        public Task DeleteDepartmentAsync(string DepartmentId);

    }
}
