using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Services.PermissionManagement.DTO
{
    public class RUDAdminDTO
    {
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public string? RoleId { get; set; }
        [EmailAddress]
        public string? Email {  get; set; }
        public string? Image {  get; set; }
    }
}
