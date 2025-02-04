using API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); //swagger
builder.Services.AddSwaggerGen(); //swagger
builder.Services.AddControllers();

//NEW 
builder.Services.AddDbContext<ServiceSchedulerContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("LocalhostConnection")));

var app = builder.Build();

app.MapControllers();

app.Run();