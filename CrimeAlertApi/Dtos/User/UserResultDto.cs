namespace CrimeAlertApi.Dtos.User
{
    public class UserResultDto
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? CNIC { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Guid? RoleId { get; set; }
        public string? Role { get; set; }
    }
}
