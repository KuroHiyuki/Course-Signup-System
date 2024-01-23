using CourseSignupSystem.Services.ProgramManagement.DTO;

namespace CourseSignupSystem.Services.ProgramManagement
{
    public interface IProgramManagementService
    {
        public Task<List<ProgramListDTO>> ListProgramAsync();
        public Task AddProgramAsync(RUDProgramDTO model);
        public Task UpdateProgramAsync(string ProgramId, RUDProgramDTO model);
        public Task DeleteProgramAsync(string ProgramId);
    }
}
