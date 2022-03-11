using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using LinqWithEF.Data;
using LinqWithEF.Models;


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

JoinProductAndCategories();

static void JoinProductAndCategories()
{
    using (Northwind db = new())
    {
        //join every product to its category to return 77 matches
        var queryJoin = db.Categories.Join(
            inner: db.Products,
            outerKeySelector: category => category.CategoryId,//exctract join key for 1st sequence
            innerKeySelector: product => product.CategoryId,//exctract join key for 2nd sequence
            resultSelector: (c, p) => new { c.CategoryName, p.ProductName, p.ProductId }//result element from two matching elements 
            ).OrderBy(cp => cp.CategoryName) ;

        foreach (var item in queryJoin)
        {
            WriteLine("Id {0} : '{1}' is in '{2}'", item.ProductId, item.ProductName, item.CategoryName);
        }
        WriteLine();

    }
}

#endregion

