using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Room
    {
        public Room()
        {
            Co_Class_Room = new HashSet<Class_Room>();

        }
        [Key]
        public string? RoomId { get; set; }
        public string? RoomName { get; set; }
        public string? Description { get; set;}
        public bool IsAirCondition { get; set; }
        public virtual ICollection<Class_Room> Co_Class_Room { get; set; }

    }
}
