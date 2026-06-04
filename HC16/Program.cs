using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder
    .AddGraphQL()
    .AddTypes()
    .AddProjections()
    .ModifyOptions(x => x.DefaultBindingBehavior = BindingBehavior.Explicit);

builder.Services.AddDbContext<CompanyContext>(
    options => options.UseSqlite("Data Source=app.db"),
    ServiceLifetime.Transient,
    ServiceLifetime.Transient
);
builder.Services.AddHostedService<InitializeDbService>();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
