using CourseSignupSystem.Services.RevenueManagement;
using CourseSignupSystem.Services.RevenueManagement.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevenueManagementController : ControllerBase
    {
        private readonly IRevenueManagementSerive _repo;

        public RevenueManagementController(IRevenueManagementSerive repo) 
        {
            _repo = repo;
        }
        [HttpGet("ExportExelRevenueDay")]
        public async Task<IActionResult> ExportRevenueDayAsync(string dateTime)
        {
            var result = await _repo.ExportExelReportRevenue(dateTime);
            return File(result!.Data!, result.Content!, result.Filepath);
        }
        [HttpGet("StudentSettled")]
        public async Task<IActionResult> GetStudentSettledListAsync()
        {
            var result = await _repo.StudentSelttledList();
            return Ok(result);
        }
        [HttpGet("TeacherSalary")]
        public async Task<IActionResult> GetTeacherSalaryListAsync()
        {
            var result = await _repo.TeacherSalaryList();
            return Ok(result);
        }
        [HttpGet("PaySlip")]
        public async Task<IActionResult> GetPayslipListAsync()
        {
            var result = await _repo.PaySlipList();
            return Ok(result);
        }
        [HttpPost("AddPaySlip")]
        public async Task<IActionResult> AddPayslipAsync(RUDPaySlipDTO model)
        {
            await _repo.AddPaySlip(model);
            return NoContent();
        }
        [HttpPut("UpdatePayslip")]
        public async Task<IActionResult> UpdatePaySlipAsync(string UserId, string ClassId, RUDPaySlipDTO model)
        {
            await _repo.UpdatePaySlip(UserId, ClassId, model);
            return NoContent();
        }
    }
}
