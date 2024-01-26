using CourseSignupSystem.Services.VacationManagement.DTO;

namespace CourseSignupSystem.Services.VacationManagement
{
    public interface IVacationManagementService
    {
        public Task<List<VacationListDTO>> VacationListAsync();
        public Task AddVacationAsync(RUDVacationDTO model);
        public Task DeleteVacationAsync(string VacationId);
        public Task UpdateVacationAsync(string VacationId, RUDVacationDTO model);
    }
}
