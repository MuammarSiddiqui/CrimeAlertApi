using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrimeAlertApi.Models
{
        [Index(nameof(Username), IsUnique = true)]
        [Index(nameof(Phone), IsUnique = true)]
        [Index(nameof(CNIC), IsUnique = true)]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? CNIC { get; set; }
        public string Username { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public Guid? RoleId { get; set; }
        public Roles? Role { get; set; }
        public bool? Active { get; set; }
        public ICollection<FeedBack>? FeedBacks { get; set; }
        public ICollection<Query>? Queries  { get; set; }
        public ICollection<Complaint>? Complaints   { get; set; }
    }
}
