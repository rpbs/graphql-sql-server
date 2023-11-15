using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphqlSQLServer;
using GraphqlSQLServer.Entity;
using GraphqlSQLServer.Interfaces;
using GraphqlSQLServer.Queries;
using GraphqlSQLServer.Repos;
using GraphqlSQLServer.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<ICarRepository, CarRepository>();

builder.Services.AddTransient<CarType>();
builder.Services.AddTransient<BrandType>();

builder.Services.AddTransient<RootQuery>();
builder.Services.AddTransient<CarQuery>();
builder.Services.AddTransient<BrandQuery>();


builder.Services.AddTransient<ISchema, RootSchema>();

builder.Services
    .AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson().AddErrorInfoProvider(opt => opt.ExposeExceptionDetails = true));

builder.Services.AddDbContext<GraphQLContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("GraphQLDbContextConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
