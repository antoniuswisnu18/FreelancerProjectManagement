using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.CustomMiddleware;
using FreelancerProjectManagementAPI.DataAccessLayer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/app_log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();


builder.Logging.ClearProviders();
builder.Logging.AddSerilog();

builder.Configuration.AddUserSecrets<Program>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IFreelancerRoleMasterRepo, FreelancerRoleMasterRepo>();
builder.Services.AddScoped<IFreelancerRoleMasterService, FreelancerRoleMasterService>();

builder.Services.AddScoped<IPaymentStatusMasterRepo, PaymentStatusMasterRepo>();
builder.Services.AddScoped<IPaymentStatusMasterService, PaymentStatusMasterService>();

builder.Services.AddScoped<IProgressStatusMasterRepo, ProgressStatusMasterRepo>();
builder.Services.AddScoped<IProgressStatusMasterService, ProgressStatusMasterService>();

builder.Services.AddScoped<IFreelancerRepo, FreelancerRepo>();
builder.Services.AddScoped<IFreelancerService, FreelancerService>();

builder.Services.AddScoped<IProjectRepo, ProjectRepo>();
builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddScoped<IProjectProgressRepo, ProjectProgressRepo>();
builder.Services.AddScoped<IProjectProgressService,  ProjectProgressService>();


var app = builder.Build();


app.UseMiddleware<ExceptionHandlingMiddleware>();


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
