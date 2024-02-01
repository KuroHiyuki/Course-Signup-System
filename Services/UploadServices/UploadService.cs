using AutoMapper;
using CourseSignupSystem.ContextData;
using CourseSignupSystem.Enumerables;
using CourseSignupSystem.Services.UploadServices.DTO;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseSignupSystem.Services.UploadServices
{
    public class UploadService : IUploadService
    {
        private readonly CourseContext _context;

        public UploadService(CourseContext context) 
        {
            _context = context;
        }
        public async Task<DownloadDTO> DownloadFileById(string UserId)
        {
            try
            {
                var file = await _context.Users!.FirstOrDefaultAsync(u => u.UserId == UserId) ?? throw new Exception($"Not found {UserId}");
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Upload", file.Image!);
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(filepath, out var contenttype))
                {
                    contenttype = "application/octet-stream";
                }
                var bytes = await System.IO.File.ReadAllBytesAsync(filepath);
                var DownloadItem = new DownloadDTO
                {
                    Data = bytes,
                    Content = contenttype,
                    Filepath = Path.GetFileName(filepath)
                };
                return DownloadItem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> UpdateFileAsync(IFormFile fileData)
        {
            try
            {
                string[] parts = fileData.FileName!.Split(".");
                switch(parts[1])
                {
                    case "png":
                        break;
                    case "jpeg":
                        break;
                    case "jpg":
                        break;
                    default: throw new Exception("Invalid File Type");
                }
               
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Upload", fileData.FileName!);
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await fileData.CopyToAsync(stream);
                }

                return filepath;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
