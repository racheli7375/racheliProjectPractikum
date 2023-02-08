using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using ProjectPractikum.Context;
using ProjectPractikum.Repositories.Interfaces;
using ProjectPractikum.Repositories.Repositories;
using ProjectPractikum.Services;
using ProjectPractikum.Services.Interfaces;
using ProjectPractikum.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<IContext, MyDbContext>();


builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IChildRepository, ChildRepository>();

builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IChildService, ChildService>();

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddAutoMapper(typeof(Mapping));

var app = builder.Build();
app.UseCors("corsPolicy");
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
