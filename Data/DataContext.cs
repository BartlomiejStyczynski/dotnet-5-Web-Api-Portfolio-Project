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
        public DbSet<Item> Items { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}