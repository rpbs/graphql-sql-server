using GraphqlSQLServer.Entity;
using GraphqlSQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GraphqlSQLServer.Repos
{
    public class BrandRepository : IBrandRepository
    {
        GraphQLContext dbContext;

        public BrandRepository(GraphQLContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> AddBrand()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await dbContext.Brands.ToListAsync();
        }

        public async Task<Brand> GetById(int id)
        {
            return await dbContext.Brands.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
