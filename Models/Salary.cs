namespace CourseSignupSystem.Models
{
    public class Salary
    {
        public string? UserId { get; set; }
        public string? ClassId { get; set; }
        public int? RateOfCharge { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? Allowance { get; set; }
        public DateTime? UpdateDate { get; set; }  
        public string? Note { get; set; }
        public virtual User? GetUser {  get; set; }
        public virtual Class? GetClass { get; set; }


    }
}
