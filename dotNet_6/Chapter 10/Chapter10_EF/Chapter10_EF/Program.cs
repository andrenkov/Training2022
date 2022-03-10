using Chapter10_EF.Models;
using EntFrame.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using static EntFrame.Shared.ProjectConst;
using static System.Console;

using Microsoft.EntityFrameworkCore.Proxies;
using Microsoft.EntityFrameworkCore.Storage;

//WriteLine($"Using {DbProvider} Db provider");

//WorkingWithEF();
//WorkingWithEFInclude();
//WorkingWithEFFilter();
//WorkingWithEFLogging();
//WorkingWithEFLike();
//WorkingWithEFLoading();


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

#region EF Include
//void WorkingWithEFInclude()
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        Write("Enter the min inits in stock : ");
//        string? unitsInStock = ReadLine();
//        int stock = int.Parse(unitsInStock);

//        IQueryable<Category> categories = DbCont.Categories?.Include(c => c.Products.Where(p => p.UnitsInStock >= stock));
//        //code below prints teh actual SQl qyery accoring to teh LinQ above
//        //WriteLine($"ToQueryString : {categories.ToQueryString()}");

//        WriteLine();
//        foreach (var category in categories)
//        {
//            WriteLine($"Category {category.CategoryName} has {category.Products.Count} products with min of {stock} in stock");
//            foreach (var product in category.Products)
//            {
//                WriteLine($"    {product.ProductName} has {product.UnitsInStock} in stock");
//            }
//        }

//        //WriteLine();
//        //var categoriesSel = from sel in DbCont.Categories where sel.CategoryId < 5 select new { sel.CategoryName, sel.Products, sel};
//        //var categoriesSel = from sel in DbCont.Categories select sel;

//        //foreach (var categorySel in categoriesSel)
//        //    {
//        //        WriteLine($"Category {categorySel.CategoryName} has {categorySel.Products.Count} products with min of {stock} in stock");
//        //    }

//        //IQueryable<Category> categories = DbCont.Categories?.Where(c => c.CategoryId < 5);
//        //WriteLine();
//        //if (categories != null)
//        //{
//        //    foreach (var category in categories)
//        //    {
//        //        WriteLine($"Category {category.CategoryName} has {category.Products.Count} products with min of {stock} in stock");
//        //    }
//        //}
//    }
//}
#endregion

#region Filtering

//void WorkingWithEFFilter()
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        WriteLine($"Products that cost more than a price, highest at top.");
//        string? input;
//        decimal price;

//        do
//        {
//            Write("Enter a product price:");
//            input = ReadLine();
//        } while (!decimal.TryParse(input, out price));

//        IQueryable<Product> products = DbCont.Products?.Where(product => product.UnitPrice > price).OrderByDescending(product => product.UnitPrice);

//        if (products != null)
//        {
//            foreach (Product product in products)
//            {
//                WriteLine("{0}: {1} costs {2:$#,##0.00} and has {3} in stock.", product.ProductId, product.ProductName, product.UnitPrice, product.UnitsInStock);
//            }
//        }
//    }
//}
#endregion

#region Logging

//void WorkingWithEFLogging()
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        //Add Logger
//        ILoggerFactory iloggerFactory = DbCont.GetService<ILoggerFactory>();
//        iloggerFactory.AddProvider(new ConsoleLoggerProvider());
//        //

//        WriteLine($"Products that cost more than a price, highest at top.");
//        string? input;
//        decimal price;

//        do
//        {
//            Write("Enter a product price:");
//            input = ReadLine();
//        } while (!decimal.TryParse(input, out price));

//        IQueryable<Product> products = DbCont.Products?
//            .TagWith("Products filtering by price and sorted")//this will show Tag in the Logger
//            .Where(product => product.UnitPrice > price)
//            .OrderByDescending(product => product.UnitPrice);

//        if (products != null)
//        {
//            foreach (Product product in products)
//            {
//                WriteLine("{0}: {1} costs {2:$#,##0.00} and has {3} in stock.", product.ProductId, product.ProductName, product.UnitPrice, product.UnitsInStock);
//            }
//        }
//    }
//}

#endregion

#region Using Like

//void WorkingWithEFLike()
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        Write("Enter part of a product name:");
//        string? input = ReadLine();

//        IQueryable<Product> products = DbCont.Products?
//            .Where(product => EF.Functions.Like(product.ProductName, $"%{input}%"));

//        if (products != null)
//        {
//            foreach (Product product in products)
//            {
//                WriteLine("{0} has {1} units in stock. Discontinues: {2}", product.ProductName, product.UnitsInStock, product.Discontinued);
//            }
//        }
//    }
//}

#endregion

#region Loading patterns

//Eager Loading (early load)
//Lazy Loading (automatic load just before it is needed)
//Explicit Loading (manual load)

//void WorkingWithEFLoading()//eager loading
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        IQueryable<Category> categories = DbCont.Categories;

//        WriteLine();
//        foreach (var category in categories)
//        {
//            WriteLine($"Category {category.CategoryName} has {category.Products.Count} products in stock");
//            foreach (var product in category.Products)
//            {
//                WriteLine($"    {product.ProductName} has {product.UnitsInStock} in stock");
//            }
//        }
//    }
//}

//for Lazy loading add Microsoft.EntityFrameworkCore.Proxies 
//and add optionsBuilder.UseLazyLoadingProxies(); into DbContext --> OnConfiguring();
//Might give the open connection error???. Need to add MultipleActiveResultSets=true. into Conn String
#endregion

#region Data manupulation

//if (AddProduct(6, "Cactus vodka", 3.62M))
//{
//    WriteLine("Product added successfully.");
//}

//if (EncreaseProdPrice(productNameStartsWith : "Cactus vodka", amount : 5.25M))
//{
//    WriteLine("Product price updated successfully.");
//}

//int del = DeleteProduct("Cactus vodka");
//if (del > 0)
//{
//    WriteLine($"{del} products deleted successfully.");
//}

//ListProducts();

//static void ListProducts()
//{
//    IConfiguration config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        WriteLine("{0,-3} {1,-35} {2,8} {3,5} {4}", "Id", "Product name", "Cost", "Stock", "Disc.");
//        foreach (Product p in DbCont.Products.OrderByDescending(prod => prod.ProductId))
//        {
//            WriteLine("{0,000} {1,-35} {2,8:#$,##.00} {3,5} {4}", p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock, p.Discontinued);
//        }
//    }
//}
//static bool AddProduct(int categoryId, string productName, decimal? price)
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        Product p = new()
//        {
//            CategoryId = categoryId,
//            ProductName = productName,
//            UnitPrice = price
//        };
//        //mark as added
//        DbCont.Add(p);
//        //save in database
//        int affected = DbCont.SaveChanges();

//        return affected == 1;
//    }
//}

//static int DeleteProduct(string productName)
//{
//    IConfiguration config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        IQueryable<Product> products = DbCont.Products?.Where(p => p.ProductName.StartsWith(productName));
//        if (products != null)
//        {
//            //mark as deleted
//            DbCont.Products.RemoveRange(products);
//            //save in database
//            int affected = DbCont.SaveChanges();
//        }

//        return 0;
//    }
//}

//bool EncreaseProdPrice(string productNameStartsWith, decimal amount)
//{
//    IConfiguration config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        Product product = DbCont.Products.First(p => p.ProductName.StartsWith(productNameStartsWith));
//        if (product != null)
//        {
//            //mark as deleted
//            product.UnitPrice = 5.25M;
//            //save in database
//            int affected = DbCont.SaveChanges();
//            return (affected == 1);
//        }
//        return false;
//    }
//}

#endregion

#region EF Transaction

//if (EncreaseProdPrice(productNameStartsWith: "Cactus vodka", amount: 5.25M))
//{
//    WriteLine("Product price updated successfully.");
//}


//ListProducts();

//static void ListProducts()
//{
//    IConfiguration config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        WriteLine("{0,-3} {1,-35} {2,8} {3,5} {4}", "Id", "Product name", "Cost", "Stock", "Disc.");
//        foreach (Product p in DbCont.Products.OrderByDescending(prod => prod.ProductId))
//        {
//            WriteLine("{0,000} {1,-35} {2,8:#$,##.00} {3,5} {4}", p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock, p.Discontinued);
//        }
//    }
//}

//bool EncreaseProdPrice(string productNameStartsWith, decimal amount)
//{
//    IConfiguration config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .Build();

//    DbContextOptions<Northwind> options = new DbContextOptionsBuilder<Northwind>()
//    .UseSqlServer(config.GetConnectionString("NorthWindDatabase"))
//    .Options;

//    using (Northwind DbCont = new(options))
//    {
//        using (IDbContextTransaction t = DbCont.Database.BeginTransaction())//begin !!!!!!!!!!!!!!!!!!!!
//        {
//            Product product = DbCont.Products.First(p => p.ProductName.StartsWith(productNameStartsWith));
//            if (product != null)
//            {
//                //mark as deleted
//                product.UnitPrice = 5.25M;
//                //save in database
//                int affected = DbCont.SaveChanges();
//                t.Commit();//commit !!!!!!!!!!!!!!!!!!!!
//                return (affected == 1);
//            }
//        }
//        return false;
//    }
//}

#endregion
