using APBD_10_s21147.Contexts;
using APBD_10_s21147.Exceptions;
using APBD_10_s21147.Models;
using APBD_10_s21147.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//dotnet tool install --global dotnet-ef
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/accounts/{id:int}", async (int id, IAccountService service, CancellationToken cancellationToken) =>
{
    try
    {
        return Results.Ok(await service.GetAccountByIdAsync(id,cancellationToken));
    }
    catch (NotFoundException e)
    {
        return Results.NotFound(e.Message);
    }
});

app.MapGet("api/accounts", async (IProductService service, CancellationToken cancellationToken) =>
{
    try
    {
        return Results.Ok(await service.GetProductsAsync(cancellationToken));
    }
    catch (NotFoundException e)
    {
        return Results.NotFound(e.Message);
    }
});
app.Run();

