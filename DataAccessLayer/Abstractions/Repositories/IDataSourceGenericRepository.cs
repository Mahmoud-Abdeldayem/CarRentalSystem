using DataAccessLayer.Entities;

namespace DataAccessLayer.Abstractions.Repositories
{
    public interface IDataSourceGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity 
    {
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid key);
        Task<TEntity> AddAsync(TEntity entity);
    }
}
