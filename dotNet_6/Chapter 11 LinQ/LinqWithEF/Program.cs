using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using LinqWithEF.Data;
using LinqWithEF.Models;
using System.Xml.Linq;


//c:\sqlite\sqlite3 northwind.db -init northwind4sqlite.sql

#region Filter and Sort

//FilterAndSort();

//static void FilterAndSort()
//{
//    using (Northwind db = new())
//    { 
//        DbSet<Product> allProducts = db.Products;
//        IQueryable<Product> filteredProducts = allProducts.Where(p => p.UnitPrice < 10M);
//        IQueryable<Product> sortedProducts = allProducts.OrderByDescending(p => p.UnitPrice);

//        WriteLine("Products less than $10:");
//        foreach (Product product in filteredProducts)
//        {
//            WriteLine("{0} : {1} costs {2:$#,##0.00}", product.ProductId, product.ProductName, product.UnitPrice);
//        }
//        WriteLine();

//        //WriteLine("Products by Price:");
//        //foreach (Product product in sortedProducts)
//        //{
//        //    WriteLine("{0} : {1} costs {2:$#,##0.00}", product.ProductId, product.ProductName, product.UnitPrice);
//        //}
//        //WriteLine();
//    }
//}

#endregion

#region Joining tables

//JoinProductAndCategories();

//static void JoinProductAndCategories()
//{
//    using (Northwind db = new())
//    {
//        //join every product to its category to return 77 matches
//        var queryJoin = db.Categories.Join(
//            inner: db.Products,
//            outerKeySelector: category => category.CategoryId,//exctract join key for 1st sequence
//            innerKeySelector: product => product.CategoryId,//exctract join key for 2nd sequence
//            resultSelector: (c, p) => new { c.CategoryName, p.ProductName, p.ProductId }//result element from two matching elements 
//            ).OrderBy(cp => cp.CategoryName) ;

//        foreach (var item in queryJoin)
//        {
//            WriteLine("Id {0} : '{1}' is in '{2}'", item.ProductId, item.ProductName, item.CategoryName);
//        }
//        WriteLine();

//    }
//}

#endregion

#region Group Joining

//GroupProductAndCategories();

//static void GroupProductAndCategories()
//{
//    using (Northwind db = new())
//    {
//        //group products by their category
//        var queryGroup = db.Categories.AsEnumerable().GroupJoin(
//            inner: db.Products,
//            outerKeySelector: category => category.CategoryId,//exctract join key for 1st sequence
//            innerKeySelector: product => product.CategoryId,//exctract join key for 2nd sequence
//            resultSelector: (c, matchingProducts) => new { c.CategoryName, Products = matchingProducts.OrderBy (prop => prop.ProductName) });

//        foreach (var category in queryGroup)
//        {
//            WriteLine("{0} has {1}", category.CategoryName, category.Products.Count());
//            foreach (var product in category.Products)
//            {
//                WriteLine($"  {product.ProductName}");
//            }
//        }
//        WriteLine();

//    }
//}

#endregion

#region Aggregating

AggregatingProducts();

static void AggregatingProducts()
{
    using (Northwind db = new())
    {
        WriteLine("{0,-25} {1,10}", "Products count:", db.Products.Count());
        WriteLine("{0,-25} {1,10:$#,##0.00}", "Highest price:", db.Products.Max(p => p.UnitPrice));
        WriteLine("{0,-25} {1,10}", "Sum of units in stock:", db.Products.Sum(p => p.UnitsInStock));
    }
}

#endregion

#region LinQ to XML

DoLinQtoXML();

static void DoLinQtoXML()
{
    using (Northwind db = new())
    {
        Product[] prodArray = db.Products.ToArray();
        if (prodArray is not null)
        {
            XElement xml = new("products", from p in prodArray
                                           select new XElement("product",
                                           new XAttribute("id", p.ProductId),
                                           new XAttribute("price", p.UnitPrice == null? 0.00 : p.UnitPrice),
                                           new XAttribute("Name", p.ProductName)));
            WriteLine(xml.ToString());
        }
    }
}

#endregion


