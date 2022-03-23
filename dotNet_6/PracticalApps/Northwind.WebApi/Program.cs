using static System.Console;
using Microsoft.AspNetCore.Mvc.Formatters;
using Packt.Shared; // AddNorthwindContext extension method

using Microsoft.OpenApi.Models;
using Northwind.WebApi.Repositories;
using Swashbuckle.AspNetCore.SwaggerUI; // SubmitMethod
using Microsoft.AspNetCore.HttpLogging; // HttpLoggingFields
using Microsoft.EntityFrameworkCore;

/// <summary>
/// API Project
/// </summary>

var builder = WebApplication.CreateBuilder(args);

#region Added for HttpClientFactory calls

builder.WebHost.UseUrls("https://localhost:5002/");
//target machine actively refused it ???
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
});//Cross-Origin Resource Sharing

#endregion

builder.Services.AddNorthwindContext();
//var sqliteServerConnection = builder.Configuration.GetConnectionString("NorthwindConnection");//Northwind local Db
////builder.Services.AddNorthwindContext(sqliteServerConnection);
//builder.Services.AddDbContext<northwindContext>(options =>
//    options.UseSqlite(sqliteServerConnection));

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers(options =>
{
    WriteLine("Default output formatters:");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter == null)
        {
            WriteLine($"  {formatter.GetType().Name}");
        }
        else // OutputFormatter class has SupportedMediaTypes
        {
            WriteLine("  {0}, Media types: {1}",
              arg0: mediaFormatter.GetType().Name,
              arg1: string.Join(", ",
                mediaFormatter.SupportedMediaTypes));
        }
    }
})
.AddXmlDataContractSerializerFormatters()
.AddXmlSerializerFormatters();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new()
{ Title = "Northwind Web API Test", Version = "v1.0"}
    ));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

//enable logging
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // default is 32k
    options.ResponseBodyLogLimit = 4096; // default is 32k
});


//builder.Services.AddHealthChecks().AddDbContextCheck<northwindContext>();

var app = builder.Build();

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
#region Added for HttpClientFactory
/// <summary>
/// allow calls from the url origin to exec get, post, put and delete on the service
/// </summary>
app.UseCors(configurePolicy: options =>
{
    options.WithMethods("GET", "POST", "PUT", "DELETE");
    options.WithOrigins(
      "https://localhost:5001"// allow requests from the MVC client via https. Can be [] like "https://localhost:5001", "http://localhost:5000" 
    );
});

//target machine actively refused it ???
//app.UseCors("AllowAll");

#endregion


app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json",
          "Northwind Service API Version 1");

        c.SupportedSubmitMethods(new[] {
      SubmitMethod.Get, SubmitMethod.Post,
      SubmitMethod.Put, SubmitMethod.Delete });
    });
}

app.UseAuthorization();

app.MapControllers();

//app.UseEndpoints(_ => { });
//app.UseEndpoints(endpoints => endpoints.MapControllers();});


app.Run();
