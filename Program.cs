using Microsoft.EntityFrameworkCore;
using moviedb.Infra;
using moviedb.Infra.Repositorios;

var builder = WebApplication.CreateBuilder(args);

var stringConexao = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
}, ServiceLifetime.Transient);

// Add services to the container.
builder.Services.AddScoped<FilmeRepositorio>();
builder.Services.AddScoped<AtorRepositorio>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
