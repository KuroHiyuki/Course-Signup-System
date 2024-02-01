using CourseSignupSystem.Services.UploadServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Quản trị viên, Bộ phân Kế Toán, Bộ phận ghi danh, Ban giám đốc")]
    public class UploadServiceController : ControllerBase
    {
        private readonly IUploadService _repo;

        public UploadServiceController(IUploadService repo)
        {
            _repo = repo;
        }
        [HttpPost("UploadImage")] 
        public async Task<IActionResult> UploadImageAsync( IFormFile formFile)
        {
            var result = await _repo.UpdateFileAsync(formFile);
            return Ok(result);
        }
        [HttpGet("DownloadImage")]
        public async Task<IActionResult> DownloadAysnc(string UserId)
        {
            var result = await _repo.DownloadFileById(UserId);
            return File(result!.Data!, result.Content!, result.Filepath);
        }
    }
}
