namespace CourseSignupSystem.Models
{
    public class Fee
    {
        public Fee() 
        {
            Co_Class = new HashSet<Class>();
        }

        public string? FeeId { get; set; }
        public int? FeeCost { get; set; }
        public decimal? Discount { get; set; }
        public string? Description { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string? TypeId { get; set; }
        public virtual FeeType? GetFeeType { get; set; }
        public virtual ICollection<Class> Co_Class { get; set; }

    }
}
