using API;
using API.Models;
using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add Services to Container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); //swagger
builder.Services.AddSwaggerGen(); //swagger

//NEW 
var connectionString = builder.Configuration.GetConnectionString("LocalHostConnection");
builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connectionString));

// Register Repositories
builder.Services.AddScoped<IEntityRepository<Employee>, EmployeeRepository>();

// Register Services
builder.Services.AddScoped<EmployeeService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// app.UseHttpsRedirection();    //waiting to determine what this is used for
// app.UseAuthorization();      // waiting to determine what this is for
app.MapControllers();
app.Run();