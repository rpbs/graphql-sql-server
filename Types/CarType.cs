using GraphQL.Types;
using GraphqlSQLServer.Entity;
using Microsoft.EntityFrameworkCore;

namespace GraphqlSQLServer.Types;

public class CarType : ObjectGraphType<Car>
{
    //GraphQLContext dbContext;

    //public CarType(GraphQLContext dbContext)
    //{
    //    this.dbContext = dbContext;
    //}

    public CarType()
	{
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("description");
        Field<DecimalGraphType>("price");
        Field<IntGraphType>("brandId");
        Field(x => x.Brand);
        

    }
}
