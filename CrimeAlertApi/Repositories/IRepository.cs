namespace CrimeAlertApi.Repositories
{
    public interface IRepository<TEntity> : IDisposable
    {
        Task Add(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Update(Guid id, TEntity entity);
        Task<TEntity> GetByIdNoTraces(Guid id);
        Task Remove(TEntity entity);
        Task<int> SaveChanges();
    }
}
