using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Permission
    {
        public Permission( )
        {
            _Role_Permission = new HashSet<Role_Permission>();
        }
        [Key]
        public string? PermissionId { get; set; }
        public string? PermissionName { get; set;}
        public virtual ICollection<Role_Permission> _Role_Permission { get; set; }

    }
}
