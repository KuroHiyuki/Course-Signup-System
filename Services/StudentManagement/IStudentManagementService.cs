using CourseSignupSystem.Services.StudentManagement.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Services.StudentManagement
{
    public interface IStudentManagementService
    {
        public Task<List<StudentListDTO>> ListStudentAsync();
        public Task<List<StudentListDTO>> ListStudentOfClassAsync(string ClassId);
        public Task TimeTableStudentAsync();
        public Task AddStudentAsync(RUDStudentDTO model);
        public Task EnrollmentAsync(EnrollmentDTO model);
        public Task UpdateStudentAsync(string UserId,RUDStudentDTO model);
        public Task DeleteStudentAsync(string UserId);
    }
}
