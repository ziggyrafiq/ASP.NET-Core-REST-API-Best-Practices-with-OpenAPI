using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using ZR.CodeExample.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
builder.Services.AddDbContext<TaskDbContext>(options =>
    options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ConfigureServices method 
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "Best Practices for Creating ASP.NET Core REST API using OpenAPI by Ziggy Rafiq",
        Description = "Unlock the art of building robust ASP.NET Core REST APIs using OpenAPI with 'Best Practices' by Ziggy Rafiq. Learn proven strategies for consistency, scalability, and security. Get expert insights at Ziggy Rafiq. ",
         Contact = new OpenApiContact
         {
              Name = "Ziggy Rafiq",
              Email ="our.name@email.com",
              
         },
        Version = "v1.0.0" });
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure method
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ziggy Rafiq Demo API V1");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
