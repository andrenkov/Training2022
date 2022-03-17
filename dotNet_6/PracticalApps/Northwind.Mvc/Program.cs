using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Northwind.Mvc.Data;

///<summary>
///The file contain hidden Program class that contains the Main entry point.
///</summary>


///<summary>
///The Builder section creates and configures th ewebsite Builder
///It registeres the DbContext
///It adds the support for the Mvc Controllers with Views
/// 
///There are two sections here: Configuration (get conn string etc.) and Services (registrered DEPENDENCY services)
///DI allows other classes to request a Servise through their constructors
///</summary>

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

///<summary>
///Configure the HTTP request pipeline
///Relative Url, Http redirection, static files, Razor pages etc.
///</summary>
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
//this maps the default route for use by MVC
//If user execute a request without a controller name etc, then it goes to /home/index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

///<summary>
///This final section is the thread-blocking method that runs the website and waits for the incomming Http requests 
///</summary>
app.Run();
