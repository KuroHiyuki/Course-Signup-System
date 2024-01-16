namespace CourseSignupSystem.Models
{
    public class Class_Program
    {
        public string? ClassId { get; set; }
        public string? ProgramId { get; set; }
        public virtual Class? GetClass {  get; set; }
        public virtual Program? GetProgram { get; set; }
    }
}
