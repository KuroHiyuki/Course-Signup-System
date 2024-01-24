using CourseSignupSystem.Enumerables;
using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Schedule
    {
        public Schedule() 
        {
            Co_Class = new HashSet<Class>();
        }
        [Key]
        public string? ScheduleId { get; set; }
        public Day ScheduleName { get; set; }
        public decimal? Duration { get; set; }
        public DateTime TimeStart { get; set; }
        public virtual ICollection<Class> Co_Class { get; set; }

    }
}
