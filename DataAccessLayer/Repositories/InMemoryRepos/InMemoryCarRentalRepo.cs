using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Entities;


namespace DataAccessLayer.Repositories.InMemoryRepos
{
    public class InMemoryCarRentalRepo : IGenericRepository<CarRental>
    {

        private readonly static List<CarRental> _entities = new List<CarRental>();
        public InMemoryCarRentalRepo()
        {
        }
        public CarRental Add(CarRental entity)
        {
            if (entity == null)
                throw new NullReferenceException("The added entity mustn't be null");
            entity.Id = Guid.NewGuid();
            _entities.Add(entity);
            return entity;
        }


        public void Delete(CarRental entity)
        {
            if (entity == null)
                throw new NullReferenceException("The removed entity mustn't be null");
            _entities.Remove(entity);
        }

        public IEnumerable<CarRental> GetAll()
        {
            var entities = _entities.ToList();
            return entities;
        }


        public CarRental GetById(Guid key)
        {
            return _entities.Where(e => e.Id == key).FirstOrDefault();
        }


        public void Update(CarRental entity)
        {
            var entityToUpdate = _entities.Where(e => e.Id == entity.Id).FirstOrDefault();
        }
    }
}
