using Northwind.Web;//startup.cs

/// <summary>
/// this replaces the commented calls below moved to the new Startup.cs
/// </summary>
Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder => {
        webBuilder.UseStartup<Startup>();
        }).Build().Run();
    
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

/// <summary>
///Vlad : add this for enhanced security with HTTP Strict Transport Security for Production
/// </summary>
//if (!app.Environment.IsDevelopment())
//{
//    app.UseHsts();
//}
/// <summary>
/// Vlad : add this for Enforce HTTPS in ASP.NET Core
/// Comment if http needed to work for web requests
/// </summary>
//app.UseHttpsRedirection();

//app.MapGet("/", () => "Hello World!");

Console.WriteLine("This executes on Run() - server starting!");

//app.Run();

Console.WriteLine("This executes after the Run() - server stoped!");//this line is ignored?