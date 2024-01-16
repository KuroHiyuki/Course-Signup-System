using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Role
    {
        public Role()
        {
            _User = new HashSet<User>();
            _Role_permission = new HashSet<Role_Permission>();
        }
        [Key]
        public string? RoleId { get; set; }
        public string? RoleName { get; set;}
        public bool? IsAdmin { get; set; }
        public virtual ICollection<User> _User { get; set; }
        public virtual ICollection<Role_Permission> _Role_permission { get; set; }



    }
}
