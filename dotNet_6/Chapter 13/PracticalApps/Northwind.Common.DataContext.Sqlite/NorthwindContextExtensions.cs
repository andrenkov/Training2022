using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    /// <summary>
    /// Add Db contect into the service collection
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
