using GraphQL.Types;
using GraphqlSQLServer.Entity;

namespace GraphqlSQLServer.Types;

public class CarType : ObjectGraphType<Car>
{
	public CarType()
	{
        Field(c => c.Id);
        Field(c => c.Name);
        Field(c => c.Description);
        Field(c => c.Price);
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("description");
        Field<DecimalGraphType>("price");
    }
}
