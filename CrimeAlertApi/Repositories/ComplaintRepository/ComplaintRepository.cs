
using CrimeAlertApi.Models;
using CrimeAlertApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dreamjob.Repository.ComplaintRepository
{
    public class ComplaintRepository : Repository<Complaint>, IComplaintRepository
    {
        public ComplaintRepository(MyContext context) : base(context)
        {
        }
    }
}
