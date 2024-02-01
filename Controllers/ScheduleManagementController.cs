using CourseSignupSystem.Services.ScheduleManagement;
using CourseSignupSystem.Services.ScheduleManagement.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleManagementController : ControllerBase
    {
        private readonly IScheduleManagementService _repo;

        public ScheduleManagementController(IScheduleManagementService repo)
        {
            _repo = repo;
        }
        [HttpGet("ScheduleList")]
        public async Task<IActionResult> GetListScheduleAsync()
        {
            var result = await _repo.ListScheduleTeacher();
            return Ok(result);
        }
        [HttpPost("AddTeachToSchedule")]
        public async Task<IActionResult> AddTeachToScheduleAsync(RUDScheduleDTO model)
        {
            await _repo.AddScheduleToTeacher(model);
            return NoContent();
        }
        [HttpDelete("DeleteTeachToSchedule")]
        public async Task<IActionResult> DeleteScheduleAsync(string ClassId)
        {
            await _repo.RemoveScheduleFromTeacher(ClassId);
            return NoContent();
        }
        [HttpPut("UpdateTeachToSchedule")]
        public async Task<IActionResult> UpdateScheduleAsync(string ClassId, RUDScheduleDTO model)
        {
            await _repo.UpdateScheduleFromTeacher(ClassId,model);
            return NoContent();
        }
    }
}
