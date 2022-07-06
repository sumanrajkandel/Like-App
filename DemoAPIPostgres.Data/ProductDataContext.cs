using DemoAPIPostgres.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace DemoAPIPostgres.Data
{
    public class ProductDataContext : DbContext
    {

        public ProductDataContext(DbContextOptions<ProductDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //added for auto-generated identity
            modelBuilder.UseSerialColumns();

            //defining unique key constraints on column of entities. 
            modelBuilder.Entity<Product>().HasIndex(e => e.ProductCode).IsUnique();
            modelBuilder.Entity<ManufacturarMaster>().HasIndex(e => e.ManufacturarCode).IsUnique();

        }


        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }


        public DbSet<ManufacturarMaster> ManufacturarMasters { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
