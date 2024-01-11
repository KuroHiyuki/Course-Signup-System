using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Room
    {
        [Key]
        public string? RoomId { get; set; }
        public string? RoomName { get; set; }
        public string? Description { get; set;}
    }
}
