namespace CourseSignupSystem.Models
{
    public class Student_Class
    {
        public string? UserId { get; set; }
        public string? ClassId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool? IsPayment { get; set; } = false;
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public virtual User? GetUser { get; set; }
        public virtual Class? GetClass { get; set; }
    }
}
