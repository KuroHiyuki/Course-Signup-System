using CourseSignupSystem.Services.FacultyManagement;
using CourseSignupSystem.Services.FacultyManagement.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyManagementController : ControllerBase
    {
        private readonly IFacultyManagementService _repo;

        public FacultyManagementController(IFacultyManagementService repo)
        {
            _repo = repo;
        }
        [HttpGet("FacultyList")]
        public async Task<IActionResult> GetFacultyListAsync()
        {
            var result = await _repo.ListFacultyAsync();
            return Ok(result);
        }

        [HttpPost("AddFaculty")]
        public async Task<IActionResult> AddFacultyAsync(RUDFacultyDTO model)
        {
            await _repo.AddFacultyAsync(model);
            return NoContent();
        }

        [HttpPut("UpdateFaculty")]
        public async Task<IActionResult> UpdateFacultyAsync(string FacultyId, RUDFacultyDTO model)
        {
            await _repo.UpdateFacultyAsync(FacultyId, model);
            return NoContent();
        }

        [HttpDelete("DeleteFaculty")]
        public async Task<IActionResult> DeleteFacultyAsync(string FacultyId)
        {
            await _repo.DeleteFacultyAsync(FacultyId);
            return NoContent();
        }
    }
}
