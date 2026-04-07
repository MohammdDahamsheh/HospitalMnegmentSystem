using Appleacation.readOnlyRepo;
using Appleacation.repo;
using Appleacation.service.comannd.Patient;
using Appleacation.service.query.Patient;
using Appleacation.unitOfWork;
using Infrustracher;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HospitalContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));


// Add repositories and unit of work
builder.Services.AddScoped(typeof(IReposotory<>), typeof(Reposetory<>));
builder.Services.AddScoped(typeof(IReadOnlyReposotory<>), typeof(ReadOnlyReposetory<>));
builder.Services.AddScoped (typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

// Add services 
builder.Services.AddScoped<PatientQueryService>();
builder.Services.AddScoped<PatientCommandService>();


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