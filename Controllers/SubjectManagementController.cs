using CourseSignupSystem.Services.SubjectManagement;
using CourseSignupSystem.Services.SubjectManagement.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectManagementController : ControllerBase
    {
        private readonly ISubjectManagementService _repo;

        public SubjectManagementController(ISubjectManagementService  repo) 
        { 
            _repo = repo;
        }
        [HttpGet("SubjectList")]
        public async Task<IActionResult> GetSubjectListAsync()
        {
            var result = await _repo.ListSubjectAsync();
            return Ok(result);
        }

        [HttpPost("AddSubject")]
        public async Task<IActionResult> AddSubjectAsync(RUDSubjectDTO model)
        {
            await _repo.AddSubjectAsync(model);
            return NoContent();
        }

        [HttpPut("UpdateSubject")]
        public async Task<IActionResult> UpdateSubjectAsync(string SubjectId, RUDSubjectDTO model)
        {
            await _repo.UpdateSubjectAsync(SubjectId, model);
            return NoContent();
        }

        [HttpDelete("DeleteSubject")]
        public async Task<IActionResult> DeleteSubjectAsync(string SubjectId)
        {
            await _repo.DeleteSubjectAsync(SubjectId);
            return NoContent();
        }
    }
}
