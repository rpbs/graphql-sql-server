using GraphQL;
using GraphQL.Types;
using GraphqlSQLServer.Interfaces;
using GraphqlSQLServer.Types;

namespace GraphqlSQLServer.Queries
{
    public class CarQuery : ObjectGraphType
    {
        public CarQuery(ICarRepository carRepository)
        {
            Field<ListGraphType<CarType>>("cars").ResolveAsync(async context =>
            {
                return await carRepository.GetCars();
            });

            Field<CarType>("car").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "carId" })).ResolveAsync(async context =>
            {
                var car = await carRepository.GetById(context.GetArgument<int>("carId"));
                return car;
            });
        }
    }
}
