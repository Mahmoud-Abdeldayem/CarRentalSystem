using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Entities;


namespace DataAccessLayer.Repositories.InMemoryRepos
{
    public class InMemoryAppUserRepo : IGenericRepository<AppUser>
    {

        private readonly static List<AppUser> _entities = new List<AppUser>()
        {
                new AppUser(){Id = Guid.NewGuid() , Email = "admin@gmail.com" , FirstName = "Mahmoud" , LastName = "Abdeldayem" , Password = "admin123"},
                new AppUser(){Id = Guid.NewGuid() , Email = "m@gmail.com" , FirstName = "Mahmoud" , LastName = "Abdeldayem" , Password = "m123" , Role = Entities.Enums.UserRole.Customer},
        };
        public InMemoryAppUserRepo()
        {
           
        }
        public AppUser Add(AppUser entity)
        {
            if (entity == null)
                throw new NullReferenceException("The added entity mustn't be null");
            entity.Id = Guid.NewGuid();
            _entities.Add(entity);
            return entity;
        }


        public void Delete(AppUser entity)
        {
            if (entity == null)
                throw new NullReferenceException("The removed entity mustn't be null");
            _entities.Remove(entity);
        }

        public IEnumerable<AppUser> GetAll()
        {
            var entities = _entities.ToList();
            return entities;
        }


        public AppUser GetById(Guid key)
        {
            return _entities.Where(e => e.Id == key).FirstOrDefault();
        }


        public void Update(AppUser entity)
        {
            var entityToUpdate = _entities.Where(e => e.Id == entity.Id).FirstOrDefault();
        }
    }
}
