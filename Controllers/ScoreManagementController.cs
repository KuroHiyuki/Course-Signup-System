using CourseSignupSystem.Services.ScoreManagement;
using CourseSignupSystem.Services.ScoreManagement.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Quản trị viên, Bộ phân Kế Toán, Bộ phận ghi danh, Ban giám đốc")]
    public class ScoreManagementController : ControllerBase
    {
        private readonly IScoreManagementService _repo;

        public ScoreManagementController(IScoreManagementService repo) 
        {
            _repo = repo;
        }
        [HttpGet("SubjectScoreList")]
        public async  Task<IActionResult> GetSubjectScoreListAsync()
        {
            var result = await _repo.ListSubjectOfScore();
            return Ok(result);
        }
        [HttpPost("AddSubjectScore")]
        public  async Task<IActionResult> AddSubjectScoreAsync(RUDSubjectOfScoreDTO model)
        {
            await _repo.AddSubjectOfScoreAsync(model);
            return NoContent();
        }
        [HttpPut("UpdateSubjectScore")]
        public async Task<IActionResult> UpdateSubjectScoreAsync(string ScoreId, string SubjectId, RUDSubjectOfScoreDTO model)
        {
            await _repo.UpdateSubjectOfScoreAsync(ScoreId, SubjectId, model);   
            return NoContent();
        }
        [HttpDelete("DeleteSubjectScore")]
        public async Task<IActionResult> DeleteSubjectScoreAsync(string ScoreId, string subjectId)
        {
            await _repo.DeleteSubjectOfScoreAsync(ScoreId,subjectId);
            return NoContent();
        }
        [HttpGet("ScoreList")]
        public async Task<IActionResult> GetScoreListAsync()
        {
            var result = await _repo.ListScoreTypeAsync();
            return Ok(result);
        }

        [HttpPost("AddScore")]
        public async Task<IActionResult> AddScoreAsync(RUDScoreTypeDTO model)
        {
            await _repo.AddScoreTypeAsync(model);
            return NoContent();
        }

        [HttpPut("UpdateScore")]
        public async Task<IActionResult> UpdateScoreAsync(string ScoreId, RUDScoreTypeDTO model)
        {
            await _repo.UpdateScoreTypeAsync(ScoreId,  model);
            return NoContent();
        }

        [HttpDelete("DeleteScore")]
        public async Task<IActionResult> DeleteScoreAsync(string ScoreId)
        {
            await _repo.DeleteScoreTypeAsync(ScoreId);
            return NoContent();
        }

    }
}
