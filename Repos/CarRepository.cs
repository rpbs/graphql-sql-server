using GraphqlSQLServer.Entity;
using GraphqlSQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GraphqlSQLServer.Repos
{
    public class CarRepository : ICarRepository
    {
        GraphQLContext dbContext;

        public CarRepository(GraphQLContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> AddCar()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetById(int id)
        {
            return this.dbContext.Cars.Include(x => x.Brand).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Car>> GetCars()
        {
            return this.dbContext.Cars.Include(x => x.Brand).ToListAsync();
        }
    }
}
