using CourseSignupSystem.Services.StudentManagement.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Services.StudentManagement
{
    public interface IStudentManagementService
    {
        public Task<List<StudentListDTO>> ListStudentAsync();
        public Task<List<StudentListDTO>> ListStudentOfClassAsync(string ClassId);
        public Task TimeTableStudentAsync();
        public Task AddStudentAsync(RUDStudent model);
        public Task EnrollmentAsync();
        public Task UpdateStudentAsync(string UserId, RUDStudent model);
        public Task DeleteStudentAsync(string UserId);
    }
}
