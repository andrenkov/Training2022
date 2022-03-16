using Packt.Shared;
using static System.Console;//for routing testing only

namespace Northwind.Web
{
    public class Startup
    {
        /// <summary>
        /// Register dependency services
        /// See p.606
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddNorthwindContext("data");//Db is in Data folder
        }
        /// <summary>
        /// Configures HTTP request pipeline
        /// see p.609
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (!env.IsDevelopment())
            {
                app.UseHsts();//addes the Strict Transport Security header
            }
            //
            //start endpoint routing (like a wwwroot endpoint for pipelines to start from.
            //Acting for endpoints matching "/" or "/index" or "/supplies")
            //Other endpoints goto UseEndpoints()
            //
            app.UseRouting();
            //
            #region Just testing specific route /bonjour
            app.Use(async (HttpContext context, Func<Task> next) =>
            {
                RouteEndpoint? rep = context.GetEndpoint() as RouteEndpoint;
                if (rep is not null)
                {
                    WriteLine($"Endpoint name: {rep.DisplayName}");
                    WriteLine($"Endpoint route pattern: {rep.RoutePattern.RawText}");
                }

                if (context.Request.Path == "/bonjour")
                {
                    // in the case of a match on URL path, this becomes a terminating
                    // delegate that returns so does not call the next delegate
                    await context.Response.WriteAsync("Bonjour Monde!");
                    return;
                }

                // we could modify the request before calling the next delegate
                await next();
                // we could modify the response after calling the next delegate
            });
            #endregion
            //
            app.UseHttpsRedirection();//to redirect HTTP requests to HTTPS

            app.UseDefaultFiles();//enable links to index.html, default.html etc.
            app.UseStaticFiles();//should go after app.UseRouting() to look for other static endpoints in wwwroot

            //commented switching to Razor pages
            //app.UseEndpoints(endpoints => 
            //{
            //    endpoints.MapGet("/hello", () => "Hello World!");//use static page for /hello endpoint only
            //    //was endpoints.MapGet("/", () => "Hello World!");
            //});

            //UseEndpoints() is paired with app.UseRouting() 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();//!!!!!! to map paths like /supplies to a razor Page file in /Pages
                endpoints.MapGet("/hello", () => "Hello World!");//use static page for /hello endpoint only
            });
        }
    }
}
