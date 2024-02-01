using CourseSignupSystem.Services.ProgramManagement;
using CourseSignupSystem.Services.ProgramManagement.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Quản trị viên, Bộ phân Kế Toán, Bộ phận ghi danh, Ban giám đốc")]
    public class ProgramManagementController : ControllerBase
    {
        private readonly IProgramManagementService _repo;

        public ProgramManagementController(IProgramManagementService repo)
        {
            _repo = repo;
        }
        [HttpGet("ProgramList")]
        public async Task<IActionResult> GetProgramListAsync()
        {
            var result = await _repo.ListProgramAsync();
            return Ok(result);
        }

        [HttpPost("AddProgram")]
        public async Task<IActionResult> AddProgramAsync(RUDProgramDTO model)
        {
            await _repo.AddProgramAsync(model);
            return NoContent();
        }

        [HttpPut("UpdateProgram")]
        public async Task<IActionResult> UpdateProgramAsync(string ProgramId, RUDProgramDTO model)
        {
            await _repo.UpdateProgramAsync(ProgramId, model);
            return NoContent();
        }

        [HttpDelete("DeleteProgram")]
        public async Task<IActionResult> DeleteProgram(string ProgramId)
        {
            await _repo.DeleteProgramAsync(ProgramId);
            return NoContent();
        }
    }
}
