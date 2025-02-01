using Pennywise.API.Clients;
using Pennywise.API.Interfaces.Clients;
using Pennywise.API.Interfaces.Repositories;
using Pennywise.API.Models.Entities;
using Pennywise.API.Repositories;

var builder = WebApplication.CreateBuilder(args);
var plaidSettings = builder.Configuration.GetSection("Plaid").Get<PlaidSettings>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

if(string.IsNullOrEmpty(plaidSettings?.BaseAddress))
    throw new InvalidOperationException("Plaid BaseAddress is not configured.");

builder.Services.AddHttpClient<IPlaidClient, PlaidClient>(client =>
{
    client.BaseAddress = new Uri(plaidSettings.BaseAddress);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddScoped<IPennywiseRepository, PennywiseRepository>();

builder.Services.AddSingleton(plaidSettings);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", builder =>
    {
        builder.WithOrigins("http://localhost:8080")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowSpecificOrigins");

app.MapControllers();

app.Run();

