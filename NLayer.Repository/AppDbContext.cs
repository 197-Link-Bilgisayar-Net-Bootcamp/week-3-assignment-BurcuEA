
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Models.TransactionModels;
using NLayer.Data.Models;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        public DbSet<ProductFull> ProductFulls { get; set; }

        //public DbSet<Teacher> Teacher { get; set; }
        //public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Entity<ProductFull>().HasNoKey();


            modelBuilder.Entity<ProductFull>().ToFunction("fc_product_full");

            modelBuilder.Entity<ProductFull>().ToView("vw_product_full");

            base.OnModelCreating(modelBuilder); 
        }

    }
}
