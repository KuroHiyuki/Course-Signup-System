using CourseSignupSystem.Services.UploadServices.DTO;

namespace CourseSignupSystem.Services.UploadServices
{
    public interface IUploadService
    {
        public Task<string> UpdateFileAsync(IFormFile fileData);
        public Task<DownloadDTO> DownloadFileById(string UserId);
    }
}
