using CourseSignupSystem.Services.PermissionManagement;
using CourseSignupSystem.Services.PermissionManagement.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionManagementController : ControllerBase
    {
        private readonly IPermissionManagementService _repo;

        public PermissionManagementController(IPermissionManagementService repo) 
        {
            _repo = repo;
        }
        [HttpGet("AdminList")]
        public async Task<IActionResult> GetAdminListAsync()
        {
            var result = await _repo.AdminList();
            return Ok(result);
        }
        [HttpPost("AddAdmin")]
        public async Task<IActionResult> AddAdminAsync(RUDAdminDTO model)
        {
            await _repo.AddAdmin(model);
            return NoContent();
        }
        [HttpPut("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdminAsync(string UserId, RUDAdminDTO model)
        {
            await _repo.UpdateAdmin(UserId, model);
            return NoContent();
        }
        [HttpDelete("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdminAsync(string UserId)
        {
            await _repo.DeleteAdmin(UserId);
            return NoContent();
        }
        [HttpGet("RoleList")]
        public async Task<IActionResult> GetRoleListAsync()
        {
            var result = await _repo.RoleList();
            return Ok(result);
        }
        [HttpPut("UpdateRolePermission")]
        public async Task<IActionResult> UpdateRolePermissionAsync(string RoleId, string? PermissionId, RUDRolePermissionDTO model)
        {
            await _repo.UpdateRolePermission(RoleId, PermissionId, model);
            return NoContent();
        }
        [HttpGet("RolePermissionList")]
        public async Task<IActionResult> GetRolePermissionListAsync(string RoleId)
        {
            var result = await _repo.RolePermissionList(RoleId);
            return Ok(result);
        }
    }
}
