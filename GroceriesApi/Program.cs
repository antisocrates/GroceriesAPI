using System;
using System.Linq;
using GroceriesApi;
using GroceriesApi.Core.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GroceriesDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("groceryListDb")));


var app = builder.Build();

using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<GroceriesDbContext>();
db.Database.EnsureCreated();
db.Database.Migrate();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/getListById", ListsController.GetList)
.WithName("GetListById")
.WithOpenApi();

app.Run();
