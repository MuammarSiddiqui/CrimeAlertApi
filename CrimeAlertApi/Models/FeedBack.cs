using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrimeAlertApi.Models
{
    public class FeedBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public bool? Active { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
    }
}
