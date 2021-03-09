using ConnectorIac.Bl.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ConnectorIac.Dal.Data
{
    public class DataSeeder
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductGroup>()
                .HasData(
                    new ProductGroup { Id = 1, Description = "Almoxarifado", Status = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductGroup { Id = 2, Description = "Armazém", Status = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product { Id = 1, Code = "12547828", Description = "Produto 1", Ean = "78554782447", Volume = 254, Weight = 188, Price = 258, ExpirationDate = DateTime.Now, Status = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, ProductGroupId = 1 },
                    new Product { Id = 2, Code = "58712544", Description = "Produto 2", Ean = "75547855547", Volume = 180, Weight = 258, Price = 145, ExpirationDate = DateTime.Now, Status = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, ProductGroupId = 2 }
                );

        }
    }
}
