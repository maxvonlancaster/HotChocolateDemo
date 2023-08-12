using HotChocolateDemo.Entities;
using HotChocolateDemo.Mutations;
using HotChocolateDemo.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DemoContext>(
    opt‌​ions =>
    {
        options.UseSqlServer(builder.Configuration["DemoConnectionString"]);
    }
);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<DemoQueries>()
    .AddMutationType<DemoMutations>();

var app = builder.Build();

app.MapGraphQL();
app.Run();
