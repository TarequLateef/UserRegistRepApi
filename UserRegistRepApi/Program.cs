using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UserRegistRepApi.Core.Repositories;
using UserRegistRepApi.Ef;
using UserRegistRepApi.Ef.Repositoris;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add the dbcontext
builder.Services.AddDbContext<RegistUser_DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RegistConn"),
    b => b.MigrationsAssembly(typeof(RegistUser_DBContext).Assembly.FullName)));

//to declare that the class of base repository emplements the ibaserepository
builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

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
