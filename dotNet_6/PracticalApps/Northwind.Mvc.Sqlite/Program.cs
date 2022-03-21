using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Northwind.Mvc.Sqlite.Data;
using Packt.Shared;//for getting the Db Contect
using System.Net.Http.Headers;

///<summary>
///The file contain hidden Program class that contains the Main entry point.
///</summary>
///

/// <summary>
/// MVC Client Project
/// </summary>


///<summary>
///The Builder section creates and configures th ewebsite Builder
///It registeres the DbContext
///It adds the support for the Mvc Controllers with Views
/// 
///There are two sections here: Configuration (get conn string etc.) and Services (registrered DEPENDENCY services)
///DI allows other classes to request a Servise through their constructors
///</summary>

var builder = WebApplication.CreateBuilder(args);

#region Added for HttpClientFactory to call the Api

builder.Services.AddHttpClient(name: "Northwind.WebApi",
    configureClient: options =>
    {
        options.BaseAddress = new Uri("https://localhost:5002/");
        options.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json", 1.0));
    });

#endregion

// Add services to the container.
//1. Db for users auth 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
//2. Data Db
var sqliteServerConnection = builder.Configuration.GetConnectionString("NorthwindConnection");//Northwind local Db
//builder.Services.AddNorthwindContext(sqliteServerConnection);
builder.Services.AddDbContext<northwindContext>(options =>
    options.UseSqlite(sqliteServerConnection));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
