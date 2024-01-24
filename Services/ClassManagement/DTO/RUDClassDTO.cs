namespace CourseSignupSystem.Services.ClassManagement.DTO
{
    public class RUDClassDTO
    {
        public string? ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? ProgramId { get; set; }
        public int MaxStudent { get; set; } = 1;
        public int? FeeCost { get; set; } = 1;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool? IsOpen { get; set; } = true;
    }
}
