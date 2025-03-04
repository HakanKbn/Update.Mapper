using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Update.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<MyContext>();
builder.Services.AddAutoMapper((serviceProvider, automapper) =>
{
    automapper.AddCollectionMappers();
    automapper.UseEntityFrameworkCoreModel<MyContext>(serviceProvider);
}, typeof(MyContext).Assembly);
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddDbContext<MyContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(MyContext)).GetName().Name); 
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Update.Mapper");
    c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
