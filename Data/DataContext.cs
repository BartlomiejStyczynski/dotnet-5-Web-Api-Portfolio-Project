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
                new Product {Id = 1, Name = "Car", Price = 10000, Barcode = "1", Description = "A car", Ratting = 6, AmountInWarehouse = 100},
                new Product {Id = 2, Name = "Carrot", Price = 1, Barcode = "2", Description = "A carrot", Ratting = 3, AmountInWarehouse = 56},
                new Product {Id = 3, Name = "Plant", Price = 1, Barcode = "3", Description = "A plant", Ratting = 6, AmountInWarehouse = 47},
                new Product {Id = 4, Name = "Boots", Price = 60, Barcode = "4", Description = "Boots", Ratting = 6, AmountInWarehouse = 5},
                new Product {Id = 5, Name = "Shovel", Price = 15, Barcode = "5", Description = "A shovel", Ratting = 6, AmountInWarehouse = 13},
                new Product {Id = 6, Name = "Chainsaw", Price = 300, Barcode = "6", Description = "A chainsaw", Ratting = 6, AmountInWarehouse = 17},
                new Product {Id = 7, Name = "Black bag", Price = 3.6f, Barcode = "7", Description = "A black bag", Ratting = 6, AmountInWarehouse = 26},
                new Product {Id = 8, Name = "Bleach", Price = 2.8f, Barcode = "8", Description = "A bleach", Ratting = 6, AmountInWarehouse = 59},
                new Product {Id = 9, Name = "Poster", Price = 27, Barcode = "9", Description = "A poster", Ratting = 6, AmountInWarehouse = 1234}
            );
        }
    }
}