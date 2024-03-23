using HealthCare.Appointments.Api.Constants;
using HealthCare.Appointments.Api.Models;
using HealthCare.Appointments.Api.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add the DbContext to the DI container
builder.Services.AddDbContext<AppointmentsDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Services Registration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<ApiEndpoints>();
builder.Services.AddTransient(typeof(IHttpRepository<>), typeof(HttpRepository<>));
builder.Services.AddHttpClient<IDoctorsApiRepository, DoctorsApiRepository>();
builder.Services.AddHttpClient<IPatientsApiRepository, PatientsApiRepository>();

// Add the AutoMapper configuration
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

