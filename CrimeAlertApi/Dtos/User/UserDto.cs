namespace CrimeAlertApi.Dtos.User
{
    public class UserDto
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? CNIC { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public Guid? RoleId { get; set; }
    }
}
