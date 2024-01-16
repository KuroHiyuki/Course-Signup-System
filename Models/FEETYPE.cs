namespace CourseSignupSystem.Models
{
    public class FeeType
    {
        public FeeType()
        {
            _Fee = new HashSet<Fee>();

        }
        public string? TypeId { get; set; }
        public string? TypeName { get; set; }
        public string? Description { get; set; }
        public decimal? RateOfCharge { get; set; }
        public virtual ICollection<Fee> _Fee { get; set; }

    }
}
