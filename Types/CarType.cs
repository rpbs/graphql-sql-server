using GraphQL.Types;

namespace GraphqlSQLServer.Types;

public class CarType : InputObjectGraphType
{
	public CarType()
	{
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("hp");
        Field<StringGraphType>("brand_id");
    }
}
