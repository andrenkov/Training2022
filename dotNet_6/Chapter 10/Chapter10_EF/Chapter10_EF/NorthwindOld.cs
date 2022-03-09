using static EntFrame.Shared.ProjectConst;
using Microsoft.EntityFrameworkCore;
using Chapter10_EF.Models;

namespace EntFrame.Shared
{
    public class NorthwindOld : DbContext
    {
        //each DbSet represents a Table
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection;
            if (DbProvider == "SQLServer")
            {
                connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;" +
                             "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                             "MultiSubnetFailover=False";
            }
            else//other Db providers
            {
            }

            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //example of using Fluent API instead of attributes
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired() //not null
                .HasMaxLength(15);
        }
    }
}

//Generating models automatically are done by cmd:
//
//dotnet ef dbcontext scarfold "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" Microsoft.EntityFrameworkCore.SqlServer --table Categories --table Products --output-dir AutoGenModels --namespace EntFrame.Shared --data-annotations --context Northwind --project Chapter10_EF --msbuildprojectextensionspath
//dotnet ef dbcontext scaffold "Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t Categories -t Products --context-dir Context -c Northwind --context-namespace EntFrame.Shared --force
//working:
//dotnet ef dbcontext scaffold "Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t Categories -t Products -t Supplies --context-dir Context -c Northwind --context-namespace EntFrame.Shared
//
