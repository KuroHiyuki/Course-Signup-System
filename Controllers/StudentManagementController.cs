using CourseSignupSystem.Models;
using CourseSignupSystem.Services.StudentManagement;
using CourseSignupSystem.Services.StudentManagement.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentManagementController : ControllerBase
    {
        private readonly IStudentManagementService _repo;

        public StudentManagementController(IStudentManagementService repo) 
        { 
            _repo = repo;
        }
        [HttpGet("ListStudent")]
        public async Task<IActionResult> GetListStudentAsync()
        {
            var result = await _repo.ListStudentAsync();
            return Ok(result);
        }
        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudentAsync(RUDStudentDTO model)
        {
            await _repo.AddStudentAsync(model);
            return NoContent();
        }
        [HttpPut("UpdateStudent/{UserId}")]
        public async Task<IActionResult> UdpateStudentAsync(string UserId, RUDStudentDTO model)
        {
            await _repo.UpdateStudentAsync(UserId,model);
            return NoContent();
        }
        [HttpDelete("DeleteStudent/{UserId}")]
        public async Task<IActionResult> DeleteStudentAsync(string UserId)
        {
            await _repo.DeleteStudentAsync(UserId);
            return NoContent();
        }
        [HttpGet("ListStudentOfClass")]
        public async Task<IActionResult> GetListStudentOfClassAsync(string ClassId)
        {
            var result = await _repo.ListStudentOfClassAsync(ClassId);
            return Ok(result);
        }
        [HttpPost("Enrollment")]
        public async Task<IActionResult> EnrollmmentAsync(EnrollmentDTO model)
        {
            await _repo.EnrollmentAsync(model);
            return NoContent();
        }
    }
}
