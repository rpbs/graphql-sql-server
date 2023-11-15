using GraphQL.Types;
using GraphqlSQLServer.Entity;

namespace GraphqlSQLServer.Types;

public class CarType : ObjectGraphType<Car>
{
	public CarType()
	{
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("description");
        Field<DecimalGraphType>("price");
        Field<IntGraphType>("brandId");
        Field(x=> x.Brand);

    }
}
