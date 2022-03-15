using Packt.Shared;

namespace Northwind.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddNorthwindContext("data");//Db is in Data folder
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseRouting();//start endpoint routing
            app.UseHttpsRedirection();
            app.UseDefaultFiles();//enable links to index.html, default.html etc.
            app.UseStaticFiles();

            //commented switching to Razor pages
            //app.UseEndpoints(endpoints => 
            //{
            //    endpoints.MapGet("/hello", () => "Hello World!");//use static page for /hello endpoint only
            //    //was endpoints.MapGet("/", () => "Hello World!");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();//!!!!!!
                endpoints.MapGet("/hello", () => "Hello World!");//use static page for /hello endpoint only);
            });
        }
    }
}
