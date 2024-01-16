namespace CourseSignupSystem.Models
{
    public class Class_Room
    {
        public string? ClassId { get; set; }
        public string? RoomId { get; set; }
        public string? AlterRoomId { get; set; }
        public virtual Class? GetClass {  get; set; }
        public virtual Room? GetRoom { get; set; }
    }
}
