using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Role
    {
        public Role()
        {
            Co_User = new HashSet<User>();
            Co_Role_permission = new HashSet<Role_Permission>();
        }
        [Key]
        public string? RoleId { get; set; }
        public string? RoleName { get; set;}
        public bool? IsAdmin { get; set; }
        public virtual ICollection<User> Co_User { get; set; }
        public virtual ICollection<Role_Permission> Co_Role_permission { get; set; }



    }
}
