
using CrimeAlertApi.Models;
using CrimeAlertApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dreamjob.Repository.EmergencyComplaintsRepository
{
    public class EmergencyComplaintsRepository : Repository<EmergencyComplaints>, IEmergencyComplaintsRepository
    {
        public EmergencyComplaintsRepository(MyContext context) : base(context)
        {
        }
    }
}
