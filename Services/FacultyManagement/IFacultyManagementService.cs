using CourseSignupSystem.Services.FacultyManagement.DTO;
using CourseSignupSystem.Services.ProgramManagement.DTO;

namespace CourseSignupSystem.Services.FacultyManagement
{
    public interface IFacultyManagementService
    {
        public Task<List<FacultyListDTO>> ListFacultyAsync();
        public Task AddFacultyAsync(RUDFacultyDTO model);
        public Task UpdateFacultyAsync(string FacultyId, RUDFacultyDTO model);
        public Task DeleteFacultyAsync(string FacultyId);
    }
}
