using CourseSignupSystem.Services.DepartmentManagement;
using CourseSignupSystem.Services.DepartmentManagement.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Quản trị viên, Bộ phân Kế Toán, Bộ phận ghi danh, Ban giám đốc")]
    public class DeparmentManagementController : ControllerBase
    {
        private readonly IDepartmentManagementService _repo;

        public DeparmentManagementController(IDepartmentManagementService repo)
        {
            _repo = repo;
        }
        [HttpGet("DepartmentList")]
        public async Task<IActionResult> GetDepartmentListAsync()
        {
            var result = await _repo.ListDepartmentAsync();
            return Ok(result);
        }
        [HttpPost("AddDepartment")]
        public async Task<IActionResult> AddDepartmentAsync(RUDDepartmentDTO model)
        {
            await _repo.AddDepartmentAsync(model);
            return NoContent();
        }

        [HttpPut("UpdateDepartment")]
        public async Task<IActionResult> UpdateDepartmentAsync(string DepartmentId, RUDDepartmentDTO model)
        {
            await _repo.UpdateDepartmentAsync(DepartmentId, model);
            return NoContent();
        }

        [HttpDelete("DeleteDepartment")]
        public async Task<IActionResult> DeleteDepartmentAsync(string DepartmentId)
        {
            await _repo.DeleteDepartmentAsync(DepartmentId);
            return NoContent();
        }
    }
}
