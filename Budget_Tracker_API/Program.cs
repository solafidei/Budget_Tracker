using Budget_Tracker_Persistence.Data;
using Budget_Tracker_Persistence.Repositories;
using Budget_Tracker_Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Budget_TrackerContext>(options => 
        options.UseSqlServer("Server =.;Database=Budget_Tracker;Trusted_Connection=True"));

builder.Services.AddTransient<IRepository, Repository>();
builder.Services.AddTransient<ITransactionService, TransactionService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
