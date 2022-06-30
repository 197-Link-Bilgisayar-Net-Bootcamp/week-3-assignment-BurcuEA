using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            //modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature
            builder.HasData(new ProductFeature
            {
                Id = 1,
                Color = "Kırmızı",
                Height = 100,
                Width = 200
            }, new ProductFeature
            {
                Id = 2,
                Color = "Mavi",
                Height = 300,
                Width = 500
            });
        }
    }


   
}
