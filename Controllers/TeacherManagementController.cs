using CourseSignupSystem.Services.TeacherManagement;
using CourseSignupSystem.Services.TeacherManagement.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherManagementController : ControllerBase
    {
        private readonly ITeacherManagementService _repo;

        public TeacherManagementController(ITeacherManagementService repo) 
        {
            _repo = repo;
        }
        [HttpGet("TeacherList")]
        public async Task<IActionResult> GetTeacherListAsync()
        {
            var result = await _repo.ListTeacherAsync();
            return Ok(result);
        }
        [HttpPost("AddTeacher")]
        public async Task<IActionResult> AddTeacherAsync(RUDTeacherDTO model)
        {
            await _repo.AddTeacherAsync(model);
            return NoContent();
        }
        [HttpPut("UpdateTeacher")]
        public async Task<IActionResult> UpdateTeacherAsync(string UserId, RUDTeacherDTO model)
        {
            await _repo.UpdateTeacherAsync(UserId, model);
            return NoContent();
        }
        [HttpDelete("DeleteTeacher")]
        public async Task<IActionResult> DeleteTeacher(string UserId)
        {
            await _repo.DeleteTeacherAsync(UserId);
            return NoContent();
        }
        [HttpGet("TeacherSchedule")]
        public async Task<IActionResult> GetTeacherScheduleAsync(string UserId)
        {
            var result = await _repo.TimeTableTeacherAsync(UserId);
            return Ok(result);
        }
    }
}
