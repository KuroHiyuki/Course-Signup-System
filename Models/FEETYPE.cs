using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class FeeType
    {
        public FeeType()
        {
            Co_Fee = new HashSet<Fee>();

        }
        [Key]
        public string? TypeId { get; set; }
        public string? TypeName { get; set; }
        public string? Description { get; set; }
        public decimal? RateOfCharge { get; set; }
        public virtual ICollection<Fee> Co_Fee { get; set; }

    }
}
