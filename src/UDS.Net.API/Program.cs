﻿using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Data;
using UDS.Net.API.HealthChecks;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks()
    .AddCheck(
        "DatabaseCheck",
        new SqlConnectionHealthCheck(connectionString),
        Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy,
        new string[] { "Database" }
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
        db.Database.Migrate();
    }
}
else
{
    // Docker containers must communicate over TLS, this only enabling this on non-dev environements
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks("/api/health");

app.Run();

