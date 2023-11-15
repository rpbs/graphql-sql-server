using GraphQL.Types;

namespace GraphqlSQLServer.Queries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery() 
        {
            Field<CarQuery>("carQuery").Resolve(context => new { });
            Field<BrandQuery>("brandQuery").Resolve(context => new { });
        }
    }
}
