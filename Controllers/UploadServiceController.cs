using CourseSignupSystem.Services.UploadServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignupSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
