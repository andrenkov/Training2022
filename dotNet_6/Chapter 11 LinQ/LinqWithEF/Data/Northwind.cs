using LinqWithEF.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqWithEF.Data
{
    public partial class Northwind : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        public Northwind(DbContextOptions<Northwind> options)
            : base(options)
        {

        }

        public Northwind()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "northwind.db");
            optionsBuilder.UseSqlite($"Filename={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(Product => Product.UnitPrice)
                .HasConversion<double>();
        }
    }
}
