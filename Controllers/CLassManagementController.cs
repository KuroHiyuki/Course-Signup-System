using CourseSignupSystem.Services.ClassManagement;
using CourseSignupSystem.Services.ClassManagement.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Quản trị viên, Bộ phân Kế Toán, Bộ phận ghi danh, Ban giám đốc")]
    public class CLassManagementController : ControllerBase
    {
        private readonly IClassManagementService _repo;

        public CLassManagementController(IClassManagementService repo) 
        {
            _repo = repo;
        }
        [HttpGet("CLassList")]
        public async Task<IActionResult> GetClassListAsync()
        {
            var result = await _repo.ListClassAsync();
            return Ok(result);
        }
        [HttpPost("AddClass")]
        public async Task<IActionResult> AddClassAsync(RUDClassDTO model)
        {
            await _repo.AddClassAsync(model);
            return NoContent();
        }
        [HttpPut("UpdateClass")]
        public  async Task<IActionResult> UpdateClassAsync(string ClassId, RUDClassDTO model)
        {
            await _repo.UpdateClassAsync(ClassId, model);
            return NoContent();
        }
        [HttpDelete("DeleteClass")]
        public async Task<IActionResult> DeleteClassAsync(string ClassId)
        {
            await _repo.DeleteClassAsync(ClassId);
            return NoContent();
        }
        [HttpGet("StudentofClass")]
        public async Task<IActionResult> GetStudentofClassListAsync(string ClassId)
        {
            var result = await _repo.ListStudentOfClass(ClassId);
            return Ok(result);
        }
        [HttpGet("SubjectofClass")]
        public async Task<IActionResult> GetSubjectofClassAsync(string ClassId)
        {
            var result = await _repo.ListSubjectOfClass(ClassId);
            return Ok(result);
        }
        [HttpPost("AddScore")]
        public async Task<IActionResult> AddScoretoStudentAsync(AddScoreOfStudentDTO model)
        {
            await _repo.AddScoreOfStudent(model);
            return NoContent();

        }
        [HttpPut("UpdateScore")]
        public async Task<IActionResult> UpdateScoretoStudentAsync(UpdateScoreDTO model, string? MarkId)
        {
            await _repo.UpdateScoreOfStudent(model, MarkId);
            return NoContent();
        }
        [HttpGet("ListScoreofClass")]
        public async Task<IActionResult> GetListScoreStudentOfClassAsync(string ClassId)
        {
            var result = await _repo.ListScoreOfClass(ClassId);
            return Ok(result);
        }
    }
}
