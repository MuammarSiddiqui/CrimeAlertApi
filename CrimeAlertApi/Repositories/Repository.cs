using CrimeAlertApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrimeAlertApi.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MyContext Db;
        protected readonly DbSet<TEntity> DbSet;
        protected Repository(MyContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }
        public virtual async Task Add(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
                await SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            try
            {
                return await DbSet.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            try
            {
                Db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                return await DbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public virtual async Task Update(Guid id, TEntity entity)
        {
            try
            {
                DbSet.Update(entity);
                await SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public virtual async Task Remove(TEntity entity)
        {
            try
            {

                DbSet.Update(entity);
                await SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public async Task<int> SaveChanges()
        {
            try
            {
                return  await Db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<TEntity> GetByIdNoTraces(Guid id)
        {
            try
            {
                Db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                return await DbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

    }
}
