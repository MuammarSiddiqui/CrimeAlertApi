
using CrimeAlertApi.Models;
using CrimeAlertApi.Repositories;
using dreamjob.Repository.FeedBackRepository;
using Microsoft.EntityFrameworkCore;

namespace dreamjob.Repository.FeedbackRepository
{
    public class FeedbackRepository : Repository<FeedBack>, IFeedBackRepository
    {
        public FeedbackRepository(MyContext context) : base(context)
        {
        }
    }
}
