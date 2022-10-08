using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Chapter10_EF.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;

namespace EntFrame.Shared
{
    public partial class Northwind : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        private readonly IConfiguration Configuration;
        public string conn;
        public Northwind(IConfiguration configuration)
        {
            Configuration = configuration;
            conn = Configuration.GetConnectionString("NorthWindDatabase");
        }
        //constructor for passing a param, for example, connection string
        public Northwind(DbContextOptions<Northwind> options)
            : base(options)
        {

            SqlServerOptionsExtension? sqlServerOptionsExtension = options.FindExtension<SqlServerOptionsExtension>();
            if (sqlServerOptionsExtension != null)
            {
                conn = sqlServerOptionsExtension.ConnectionString;
            }
        }

        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(conn);
            }

            optionsBuilder.UseLazyLoadingProxies();// - gives the open connection error unless you add MultipleActiveResultSets=true into the conn string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasIndex(e => e.CompanyName, "CompanyName");

                entity.HasIndex(e => e.PostalCode, "PostalCode");

                entity.Property(e => e.Address).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.CompanyName).HasMaxLength(40);

                entity.Property(e => e.ContactName).HasMaxLength(30);

                entity.Property(e => e.ContactTitle).HasMaxLength(30);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.Fax).HasMaxLength(24);

                entity.Property(e => e.HomePage).HasColumnType("ntext");

                entity.Property(e => e.Phone).HasMaxLength(24);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.Region).HasMaxLength(15);
            });

            //add a Global Filter t exlude all Discontinued products
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.Discontinued);


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
