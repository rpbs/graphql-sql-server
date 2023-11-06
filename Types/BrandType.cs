using GraphQL.Types;

namespace GraphqlSQLServer.Types;

public class BrandType : InputObjectGraphType
{
    public BrandType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("country");
    }
}
