using GraphqlSQLServer.Entity;

namespace GraphqlSQLServer.Interfaces;

public interface ICarRepository
{
    Task<List<Car>> GetCars();
    Task<int> AddCar();
    Task<Car> GetById(int v);
}
