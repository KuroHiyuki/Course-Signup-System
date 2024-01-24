using CourseSignupSystem.Services.ClassManagement.DTO;

namespace CourseSignupSystem.Services.ClassManagement
{
    public interface IClassManagementService
    {
        public Task<List<ClassListDTO>> ListClassAsync();
        public Task AddClassAsync(RUDClassDTO model);
        public Task UpdateClassAsync(string ClassId, RUDClassDTO model);
        public Task DeleteClassAsync(string ClassId);
        public Task AddScore();
        public Task<List<StudentOfClassListDTO>> ListStudentOfClass(string? ClassId);
        public Task<List<SubjectOfClassListDTO>> ListSubjectOfClass(string? ClassId);
        public Task ListScoreOfClass();
    }
}
