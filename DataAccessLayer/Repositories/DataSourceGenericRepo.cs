using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Repositories
{
    public class DataSourceGenericRepo<TEntity> : IDataSourceGenericRepository<TEntity> where TEntity : BaseEntity
    {

        private readonly AppDbContext _context;

        public DataSourceGenericRepo(AppDbContext context)
        {
             _context = context;
        }
        public TEntity Add(TEntity entity)
        {
            if (entity == null)
                throw new NullReferenceException("The added entity mustn't be null");
             _context.Add(entity); 
            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
                throw new NullReferenceException("The added entity mustn't be null");
            await _context.AddAsync(entity);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
                throw new NullReferenceException("The removed entity mustn't be null");
            _context.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            var entities = _context.Set<TEntity>().ToList();
            return entities;
        }

        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            var entities = _context.Set<TEntity>();    
            return entities;
        }

        public TEntity GetById(Guid key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        public async Task<TEntity> GetByIdAsync(Guid key)
        {
            return await _context.Set<TEntity>().FindAsync(key);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
