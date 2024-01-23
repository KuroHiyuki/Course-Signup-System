using CourseSignupSystem.Services.TeacherManagement.DTO;

namespace CourseSignupSystem.Services.TeacherManagement
{
    public interface ITeacherManagementService
    {
        public Task<List<TeacherListDTO>> ListTeacherAsync();
        public Task TimeTableTeacherAsync();
        public Task AddTeacherAsync(RUDTeacherDTO model);
        public Task UpdateTeacherAsync(string UserId, RUDTeacherDTO model);
        public Task DeleteTeacherAsync(string UserId);
    }
}
