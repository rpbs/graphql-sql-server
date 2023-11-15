using GraphQL.Types;
using GraphqlSQLServer.Entity;

namespace GraphqlSQLServer.Types;

public class BrandType : ObjectGraphType<Brand>
{
    public BrandType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("country");
    }
}
