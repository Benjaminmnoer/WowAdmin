using Microsoft.EntityFrameworkCore;
using WowAdmin.Persistence.Context;
using WowAdmin.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AccountContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("AccountDatabase")));
builder.Services.AddDbContext<CharacterContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("CharactersDatabase")));
builder.Services.AddDbContext<WorldContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WorldDatabase")));
builder.Services.AddTransient<AccountRepository>();

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
