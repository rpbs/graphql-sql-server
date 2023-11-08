using GraphQL.Types;
using GraphqlSQLServer.Entity;

namespace GraphqlSQLServer.Types;

public class BrandType : ObjectGraphType<Brand>
{
    public BrandType()
    {
        Field(c => c.Id);
        Field(c => c.Name);
        Field(c => c.Country);
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("country");
    }
}
