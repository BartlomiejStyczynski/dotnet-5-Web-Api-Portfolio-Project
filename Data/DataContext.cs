using dotnet_5_Web_Api_Portfolio_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_5_Web_Api_Portfolio_Project.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product {Id = 1, Name = "Car", Description = "A car", Ratting = 6, AmountInWarehouse = 100},
                new Product {Id = 2, Name = "Carrot", Description = "A carrot", Ratting = 3, AmountInWarehouse = 56},
                new Product {Id = 3, Name = "Plant", Description = "A plant", Ratting = 6, AmountInWarehouse = 47},
                new Product {Id = 4, Name = "Boots", Description = "Boots", Ratting = 6, AmountInWarehouse = 5},
                new Product {Id = 5, Name = "Shovel", Description = "A shovel", Ratting = 6, AmountInWarehouse = 13},
                new Product {Id = 6, Name = "Chainsaw", Description = "A chainsaw", Ratting = 6, AmountInWarehouse = 17},
                new Product {Id = 7, Name = "Black bag", Description = "A black bag", Ratting = 6, AmountInWarehouse = 26},
                new Product {Id = 8, Name = "Bleach", Description = "A bleach", Ratting = 6, AmountInWarehouse = 59},
                new Product {Id = 9, Name = "Poster", Description = "A poster", Ratting = 6, AmountInWarehouse = 1234}
            );
        }

    }
}