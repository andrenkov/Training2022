using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Packt.Shared
{
    /// <summary>
    /// Add Db contect into the service collection
    /// This is the sqlite version
    /// See p.563 for the MsSQL version of AddNorthwindContext()
    /// </summary>
    public static class NorthwindContextExtensions
    {
        public static IServiceCollection AddNorthwindContext(this IServiceCollection services, string relativePath = "..")
        {
            string databasePath = Path.Combine(relativePath, "Northwind.Db");

            services.AddDbContext<northwindContext>(options =>
            options.UseSqlite($"Data Source={databasePath}"));

            return services;
        }
    }
}
