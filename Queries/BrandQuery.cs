using GraphQL;
using GraphQL.Types;
using GraphqlSQLServer.Entity;
using GraphqlSQLServer.Interfaces;
using GraphqlSQLServer.Types;

namespace GraphqlSQLServer.Queries
{
    public class BrandQuery : ObjectGraphType
    {
        public BrandQuery(IBrandRepository brandRepository)  
        {
            Field<ListGraphType<BrandType>>("brands").ResolveAsync(async context =>
            {
                return await brandRepository.GetBrands();
            });

            Field<BrandType>("brand").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "brandId" })).ResolveAsync(async context =>
            {
                Brand car = await brandRepository.GetById(context.GetArgument<int>("brandId"));
                return car;
            });

        }
    }
}
