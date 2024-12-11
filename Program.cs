using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<IFreelancerRoleMasterRepo, FreelancerRoleMasterRepo>();
builder.Services.AddScoped<IFreelancerRoleMasterService, FreelancerRoleMasterService>();


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
