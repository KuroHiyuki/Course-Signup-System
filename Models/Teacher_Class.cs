namespace CourseSignupSystem.Models
{
    public class Teacher_Class
    {
        public string? UserId { get; set; }
        public string? ClassId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool? IsPayment { get; set; }
        public virtual User? GetUser { get; set; }
        public virtual Class? GetClass { get; set; }
    }
}
