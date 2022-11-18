using Finaktiva.DDD_1.API.AplicationServices;
using Finaktiva.DDD_1.API.Queries;
using Finaktiva.DDD_1.Domain.Repositories;
using Finaktiva.DDD_1.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContex>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Finaktiva"));
});
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<PersonQueries>();
builder.Services.AddScoped<FinaktivaServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
