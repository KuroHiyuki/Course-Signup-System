using CourseSignupSystem.Services.FacultyManagement.DTO;
using CourseSignupSystem.Services.VacationManagement;
using CourseSignupSystem.Services.VacationManagement.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Quản trị viên, Bộ phân Kế Toán, Bộ phận ghi danh, Ban giám đốc")]
    public class VacationManagementController : ControllerBase
    {
        private readonly IVacationManagementService _repo;

        public VacationManagementController(IVacationManagementService repo) 
        {
            _repo = repo;
        }
        [HttpGet("VacationList")]
        public async Task<IActionResult> GetVacationListAsync()
        {
            var result = await _repo.VacationListAsync(); 
            return Ok(result);
        }

        [HttpPost("AddVacation")]
        public async Task<IActionResult> AddVacationAsync(RUDVacationDTO model)
        {
            await _repo.AddVacationAsync(model); 
            return NoContent();
        }

        [HttpPut("UpdateVacation")]
        public async Task<IActionResult> UpdateVacationAsync(string VacationId, RUDVacationDTO model)
        {
            await _repo.UpdateVacationAsync(VacationId, model);  
            return NoContent();
        }

        [HttpDelete("DeleteVacation")]
        public async Task<IActionResult> DeleteVacationAsync(string VacationId)
        {
            await _repo.DeleteVacationAsync(VacationId); 
            return NoContent();
        }
    }
}
