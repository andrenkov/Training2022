using Chapter10_EF.Models;
using EntFrame.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static EntFrame.Shared.ProjectConst;
using static System.Console;

Console.WriteLine($"Using {DbProvider} Db provider");

//WorkingWithEF();
WorkingWithEFFilter();

#region WorkingWithEF
//void WorkingWithEF()
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    //Northwind DbCont = new(config);

//    using (Northwind DbCont = new(options))
//    {
//        WriteLine($"Using {DbCont.Database.GetConnectionString()}");
//        WriteLine();

//        IQueryable<Category> categories = DbCont.Categories?.Include(c => c.Products);
//        if (categories is null)
//        {
//            WriteLine("No products");
//            return;
//        }
//        WriteLine($"There are: {categories.Count()} categories in the database");
//        WriteLine();
//        foreach (var category in categories)
//        {
//            WriteLine($"Category {category.CategoryName} has {category.Products.Count} products");
//        }
//    }
//}
#endregion

void WorkingWithEFFilter()
{
    IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
    .Options;

    using (Northwind DbCont = new(options))
    {
        Write("Enter the min inits in stock : ");
        string? unitsInStock = ReadLine();
        int stock = int.Parse(unitsInStock);

        IQueryable<Category> categories = DbCont.Categories?.Include(c => c.Products.Where(p => p.UnitsInStock >= stock));
        WriteLine();
        foreach (var category in categories)
        {
            WriteLine($"Category {category.CategoryName} has {category.Products.Count} products with min of {stock} in stock");
            foreach (var product in category.Products)
            {
                WriteLine($"    {product.ProductName} has {product.UnitsInStock} in stock");
            }
        }

        //IQueryable<Category> categories = DbCont.Categories?.Where(c => c.CategoryId < 5);
        //WriteLine();
        //if (categories != null)
        //{
        //    foreach (var category in categories)
        //    {
        //        WriteLine($"Category {category.CategoryName} has {category.Products.Count} products with min of {stock} in stock");
        //    }
        //}
    }
}

