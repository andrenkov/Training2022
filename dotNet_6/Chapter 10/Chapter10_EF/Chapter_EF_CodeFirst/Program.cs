using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using StudentAndCourses;
using StudentAndCourses.Models;
using static System.Console;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Design;


Run();

static async void Run()
{
    //IConfiguration config = new ConfigurationBuilder()
    //.AddJsonFile("appsettings.json")
    //.Build();

    //DbContextOptions<Academy> options = new DbContextOptionsBuilder<Academy>()
    //.UseSqlServer(config.GetConnectionString("AcademyDatabase"))
    //.Options;

    DbContextOptions<Academy> options = new DbContextOptionsBuilder<Academy>()
    .UseSqlite("AcademyDatabase")
    .Options;

    WriteLine("Db options loaded");

    try
    {
        using (Academy DbCont = new())
        {
            WriteLine("Deleting Db");
            bool deleted = await DbCont.Database.EnsureDeletedAsync();
            WriteLine($"Db deleted : {deleted}");

            WriteLine("Creating Db");
            bool created = await DbCont.Database.EnsureCreatedAsync();
            WriteLine($"Db created : {created}");

            WriteLine($"Sql script used : {DbCont.Database.GenerateCreateScript()}");

            foreach (Student s in DbCont.Students.Include(s => s.Courses))
            {
                WriteLine("{0} {1} attends the following {2} cources:", s.FirstName, s.LastName, s.Courses.Count);
                foreach (Course c in s.Courses)
                {
                    WriteLine($"   {c.Title}");
                }
            }

        }
    }
    catch (Exception ex)
    {
        WriteLine($"Error : {ex.Message}");
    }
}
