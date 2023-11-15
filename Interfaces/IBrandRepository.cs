using GraphqlSQLServer.Entity;

namespace GraphqlSQLServer.Interfaces;

public interface IBrandRepository
{
    Task<int> AddBrand();
    Task<List<Brand>> GetBrands();
    Task<Brand> GetById(int id);
}
