namespace CourseSignupSystem.Models
{
    public class Role_Permission
    {
        public string? RoleId { get; set; }
        public string? PermissionId { get; set;}
        public DateTime? UpdateDate { get; set; }
        public virtual Role? GetRole { get; set; }
        public virtual Permission? GetPermission { get; set; }
    }
}
