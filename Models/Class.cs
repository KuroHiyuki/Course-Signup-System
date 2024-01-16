using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Class
    {
        public Class() 
        { 
            _Class_Program = new HashSet<Class_Program>();
            _Class_Room = new HashSet<Class_Room>();
            _Salary = new HashSet<Salary>();
            _Class_Student = new HashSet<Student_Class>();
            _Class_Teacher = new HashSet<Teacher_Class>();
        }
        [Key]
        public string? ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxStudent { get; set; }
        public bool? IsOpen { get; set; } = true;
        public string? Term { get; set; }
        public string? ScheduleId { get; set; } 
        public string? FeeId { get; set; }
        public string? SubjectId { get; set; }
        public virtual Schedule? GetSchedule { get; set; }
        public virtual Fee? GetFee { get; set; }
        public virtual Subject? GetSubject { get; set; }
        public virtual ICollection<Class_Program> _Class_Program { get; set; }
        public virtual ICollection<Class_Room> _Class_Room { get; set; }
        public virtual ICollection<Salary> _Salary { get; set; }
        public virtual ICollection<Student_Class> _Class_Student { get; set; }
        public virtual ICollection<Teacher_Class> _Class_Teacher { get; set; }
    }
}
