using GraphqlSQLServer.Entity;
using GraphqlSQLServer.Interfaces;

namespace GraphqlSQLServer.Repos
{
    public class CarRepository : ICarRepository
    {
        public Task<int> AddCar()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetById(int v)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> GetCars()
        {
            throw new NotImplementedException();
        }
    }
}
