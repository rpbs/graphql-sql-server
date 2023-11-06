namespace GraphqlSQLServer.Repositories;

public interface ICarRepository
{
    Task<int> AddCar();
}
