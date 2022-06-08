
using CrimeAlertApi.Models;
using CrimeAlertApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dreamjob.Repository.QueryRepository
{
    public class QueryRepository : Repository<Query>, IQueryRepository
    {
        public QueryRepository(MyContext context) : base(context)
        {
        }
    }
}
