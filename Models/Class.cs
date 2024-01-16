using System.ComponentModel.DataAnnotations;

namespace CourseSignupSystem.Models
{
    public class Class
    {
        public Class() 
        {
            Co_Class_Program = new HashSet<Class_Program>();
            Co_Class_Room = new HashSet<Class_Room>();
            Co_Salary = new HashSet<Salary>();
            Co_Student_Class = new HashSet<Student_Class>();
            Co_Teacher_Class = new HashSet<Teacher_Class>();
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
        public virtual ICollection<Class_Program> Co_Class_Program { get; set; }
        public virtual ICollection<Class_Room> Co_Class_Room { get; set; }
        public virtual ICollection<Salary> Co_Salary { get; set; }
        public virtual ICollection<Student_Class> Co_Student_Class { get; set; }
        public virtual ICollection<Teacher_Class> Co_Teacher_Class { get; set; }
    }
}
