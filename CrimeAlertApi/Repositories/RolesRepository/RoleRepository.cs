
using CrimeAlertApi.Models;
using CrimeAlertApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dreamjob.Repository.RolesRepository
{
    public class RolesRepository : Repository<Roles>, IRolesRepository
    {
        public RolesRepository(MyContext context) : base(context)
        {
        }
    }
}
