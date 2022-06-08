using Microsoft.EntityFrameworkCore;

namespace CrimeAlertApi.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {}
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        public virtual DbSet<EmergencyComplaints> EmergencyComplaintts { get; set; }
    }
}
