using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Packt.Shared
{
    /// <summary>
    /// Add Db contect into the service collection
    /// This is the sqlite version
    /// See p.563 for the MsSQL version of AddNorthwindContext()
    /// </summary>
    public static class NorthwindContextExtensions //p.562
    {
        public static IServiceCollection AddNorthwindContext(this IServiceCollection services, string relativePath = "..")
        {
            string databasePath = Path.Combine(relativePath, "northwind.db");
            string ds = "Data source=" + databasePath;
            

            services.AddDbContext<northwindContext>(options =>
            options.UseSqlite(ds));//"Data source=data//northwind.db"

            return services;
        }
    }
}
