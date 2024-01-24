namespace CourseSignupSystem.Services.ClassManagement.DTO
{
    public class ClassListDTO
    {
        public string? ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? ProgramName { get; set; }
        public string? DepartmentName { get; set; }
        public int NumberOfStudent { get; set; }
        public bool? IsOpen { get; set; } = true;
        public int? FeeCost { get; set; }
        public int MaxStudent { get; set; }
    }
}
