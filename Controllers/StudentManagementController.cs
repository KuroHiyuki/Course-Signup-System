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
        public async Task<IActionResult> AddStudentAsync(RUDStudent model)
        {
            await _repo.AddStudentAsync(model);
            return NoContent();
        }
        [HttpPut("UpdateStudent/{UserId}")]
        public async Task<IActionResult> UdpateStudentAsync(string UserId, RUDStudent model)
        {
            await _repo.UpdateStudentAsync(UserId, model);
            return NoContent();
        }
        [HttpDelete("DeleteStudent/{UserId}")]
        public async Task<IActionResult> DeleteStudentAsync(string UserId)
        {
            await _repo.DeleteStudentAsync(UserId);
            return NoContent();
        }
    }
}
