using Microsoft.EntityFrameworkCore;

namespace GraphqlSQLServer.Entity
{
    public class GraphQLContext : DbContext
    {



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
