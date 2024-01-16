using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Programs
    {
        public Programs()
        {
            _Class_Prgram = new HashSet<Class_Program>();
        }
        [Key]
        public string? ProgramId { get; set; }
        public string? ProgramName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime? EndDate { get; set;}
        public string? Description { get; set; }
        public virtual ICollection<Class_Program> _Class_Prgram { get; set; }


    }
}
