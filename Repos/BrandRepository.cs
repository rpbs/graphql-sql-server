using GraphqlSQLServer.Entity;
using GraphqlSQLServer.Interfaces;

namespace GraphqlSQLServer.Repos
{
    public class BrandRepository : IBrandRepository
    {
        public Task<int> AddBrand()
        {
            throw new NotImplementedException();
        }

        public Task<List<Brand>> GetBrands()
        {
            throw new NotImplementedException();
        }
    }
}
