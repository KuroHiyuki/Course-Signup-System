using CourseSignupSystem.Services.ScheduleManagement.DTO;

namespace CourseSignupSystem.Services.ScheduleManagement
{
    public interface IScheduleManagementService
    {
        public Task<List<ScheduleToTeacherDTO>> ListScheduleTeacher();
        public Task AddScheduleToTeacher(RUDScheduleDTO model);
        public Task RemoveScheduleFromTeacher(string? ClassId);
        public Task UpdateScheduleFromTeacher(string? ClassId, RUDScheduleDTO model);

    }
}
