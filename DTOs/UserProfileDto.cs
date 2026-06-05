namespace RegistrationPortal.Api.DTOs
{
    public class UserProfileDto
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Skills { get; set; } = new();
    }
}