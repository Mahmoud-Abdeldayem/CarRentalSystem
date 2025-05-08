using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Entities;


namespace DataAccessLayer.Repositories.InMemoryRepos
{
    public class InMemoryCarRepo : IGenericRepository<Car>
    {

        private readonly static List<Car> _entities = new List<Car>()
        {
            new Car(){Id = Guid.NewGuid() , Brand = "BMW" , Model = "BMW99" , IsRented = false , RentPrice = 200 , Decription = "Old Fashioned car" , ImagePath = @"C:\\Users\\mahmoud\\Desktop\\bmw.jpeg"},
             new Car
    {
        Id = Guid.NewGuid(),
        Brand = "Toyota",
        Model = "Corolla22",
        IsRented = true,
        RentPrice = 150,
        Decription = "Economic and reliable",
        ImagePath = @"C:\Users\mahmoud\Desktop\toyota.jpeg"
    },
    new Car
    {
        Id = Guid.NewGuid(),
        Brand = "Mercedes",
        Model = "E-Class 2021",
        IsRented = false,
        RentPrice = 300,
        Decription = "Luxury sedan",
        ImagePath = @"C:\Users\mahmoud\Desktop\mercedes.jpeg"
    },
        };
        public InMemoryCarRepo()
        {
        }
        public Car Add(Car entity)
        {
            if (entity == null)
                throw new NullReferenceException("The added entity mustn't be null");
            entity.Id = Guid.NewGuid();
            _entities.Add(entity);
            return entity;
        }


        public void Delete(Car entity)
        {
            if (entity == null)
                throw new NullReferenceException("The removed entity mustn't be null");
            _entities.Remove(entity);
        }

        public IEnumerable<Car> GetAll()
        {
            var entities = _entities.ToList();
            return entities;
        }


        public Car GetById(Guid key)
        {
            return _entities.Where(e => e.Id == key).FirstOrDefault();
        }


        public void Update(Car entity)
        {
            var carIndex = -1;
            for(int i = 0; i < _entities.Count; i++)
            {
                if(_entities[i].Id == entity.Id)
                {
                    carIndex = i;
                    break;
                }
            }

            _entities[carIndex] = entity;
        }
    }
}
