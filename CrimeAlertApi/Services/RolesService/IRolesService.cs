using CrimeAlertApi.Models;


namespace dreamjob.Services.RolesService
{
    public interface IRolesService
    {
            Task<IEnumerable<Roles>> GetAll();
            Task<Roles> GetById(Guid id);
        Task<Roles> GetByIdNoTraces(Guid id);
        Task<Roles> Add(Roles Roles);
            Task<Roles> Update(Guid id, Roles Roles);
            Task<bool> Remove(Roles Roles);
    }
}
