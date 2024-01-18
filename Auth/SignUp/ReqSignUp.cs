using CourseSignupSystem.Enumerables;

namespace CourseSignupSystem.Auth.SignUp
{
    public class ReqSignUp
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public string? NumberPhone { get; set; }
        public Sex Sex { get; set; } = Sex.Nonbinary;
        public string? ParentName { get; set; }
    }
}
