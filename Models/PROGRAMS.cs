using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Programs
    {
        public Programs()
        {
            Co_Class_Prgram = new HashSet<Class_Program>();
            Co_Subjects = new HashSet<Subject>();
        }
        [Key]
        public string? ProgramId { get; set; }
        public string? ProgramName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime? EndDate { get; set;}
        public string? Description { get; set; }
        public virtual ICollection<Subject>? Co_Subjects { get; set; }
        public virtual ICollection<Class_Program>? Co_Class_Prgram { get; set; }


    }
}
