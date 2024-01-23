using CourseSignupSystem.Services.SubjectManagement.DTO;

namespace CourseSignupSystem.Services.SubjectManagement
{
    public interface ISubjectManagementService
    {
        public Task<List<SubjectListDTO>> ListSubjectAsync();
        public Task AddSubjectAsync(RUDSubjectDTO model);
        public Task UpdateSubjectAsync(string SubjectId, RUDSubjectDTO model);
        public Task DeleteSubjectAsync(string SubjectId);

    }
}
