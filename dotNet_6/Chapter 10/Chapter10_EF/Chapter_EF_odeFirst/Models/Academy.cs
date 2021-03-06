using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using static System.Console;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Design;

namespace StudentAndCourses.Models
{
    public class Academy : DbContext
    {
        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }

        public Academy()
        {
        }

        public Academy(DbContextOptions<Academy> options)
            : base(options)
        {
            //options.UseSqlite("DataSource=academyp.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string path = Path.Combine(Environment.CurrentDirectory, "academy.db");
            //WriteLine($"Using {path} database file.");

            //if (!optionsBuilder.IsConfigured)
            //{
            //    IConfigurationRoot configuration = new ConfigurationBuilder()
            //       .SetBasePath(Directory.GetCurrentDirectory())
            //       .AddJsonFile("appsettings.json")
            //       .Build();
            //    var connectionString = configuration.GetConnectionString("AcademyDatabase");
            //    optionsBuilder.UseSqlServer(connectionString);
            //}

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                //var connectionString = configuration.GetConnectionString("AcademyDatabase");
                optionsBuilder.UseSqlite("DataSource=academy.db");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            //Fluent API validation rules
            modelBuilder.Entity<Student>().Property(s => s.LastName).HasMaxLength(30).IsRequired();

            #region seed sample data
            Student alice = new() 
            {
                StudentId = 1,
                FirstName = "Alice",
                LastName = "Jones"
            };
            Student bob = new()
            {
                StudentId = 2,
                FirstName = "Bob",
                LastName = "Smith"
            };
            Student mary = new()
            {
                StudentId = 3,
                FirstName = "Mary",
                LastName = "Hay"
            };


            Course csharp = new()
            {
                CourseId = 1,
                Title = "C# 10 course"
            };
            Course vb = new()
            {
                CourseId = 2,
                Title = "Visual Basic"
            };
            #endregion

            modelBuilder.Entity<Student>().HasData(alice, bob, mary);
            modelBuilder.Entity<Course>().HasData(csharp, vb);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithMany(s => s.Courses)
                .UsingEntity(e => e.HasData(
                    //all students signed up for C# course 
                    new { CoursesCourseId = 1, StudentsStudentId = 1},
                    new { CoursesCourseId = 1, StudentsStudentId = 2},
                    new { CoursesCourseId = 1, StudentsStudentId = 3},
                    //only one student signed up for Vb
                    new { CoursesCourseId = 2, StudentsStudentId = 2 }
                    ));


        }
    }
}
