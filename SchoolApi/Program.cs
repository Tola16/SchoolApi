using Microsoft.EntityFrameworkCore;
using SchoolApi.AppContext;
using SchoolApi.Repo.Implementations;
using SchoolApi.Repo.Interfaces;
using SchoolApi.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>
    (a => a.UseSqlServer(builder.Configuration.GetConnectionString("con")));

builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(IGenericRepo<>));
builder.Services.AddScoped<ITeacherRepo,TeacherRepo>();
builder.Services.AddScoped<IStudentRepo,StudentRepo>();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();


builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
