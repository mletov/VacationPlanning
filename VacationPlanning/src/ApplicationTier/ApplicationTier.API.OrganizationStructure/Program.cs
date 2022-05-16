using ApplicationTier.API.OrganizationStructure;
using Microsoft.EntityFrameworkCore;
 
var builder = WebApplication.CreateBuilder();

// получаем строку подключения из файла конфигурации
var connectionString = builder.Configuration.GetConnectionString("MyTestConnect");

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<SchoolDBContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapGet("/", (SchoolDBContext db) => db.Students.ToList());

app.Run();

/*
using ApplicationTier.API.OrganizationStructure;
using ApplicationTier.Domain.Interfaces;

using DataTier.EF.OrganizationStructure;
using DataTier.EF.OrganizationStructure.Data;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", false, true)
    .AddEnvironmentVariables();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

//
//builder.Services.AddScoped<IDbInit, InitDb>();


builder.Services.AddDbContext<DataContextStruct>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PGOrgConnect"));
    options.UseLazyLoadingProxies();
    options.UseNpgsql(builder.Configuration.GetConnectionString("PGOrgConnect"),
                        b => b.MigrationsAssembly("ApplicationTier.API.OrganizationStructure"));
    
});

var connectionString = builder.Configuration.GetConnectionString("MyTestConnect");
builder.Services.AddDbContext<SchoolDBContext>(options =>
    options.UseSqlServer(connectionString));






//builder.Host.ConfigureContainer<InitDb>(builder => builder.InitializeDb());

//builder.Configuration.Add<InitDb>(builder => builder.InitializeDb());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseAuthorization();

app.MapControllers();




app.Run();

*/




