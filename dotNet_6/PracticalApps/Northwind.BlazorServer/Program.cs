using Northwind.BlazorServer.Data;
using Packt.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();//Blazor Server App
builder.Services.AddSingleton<WeatherForecastService>();

//Get Db entities
builder.Services.AddNorthwindContext(); //this is how the example showing it. Db must be in the "Solution Items" folder

builder.Services.AddTransient<INorthwindService, NorthwindService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//Blazor Server App
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
//

app.Run();
