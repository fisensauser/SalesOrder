using Microsoft.EntityFrameworkCore;
using SalesOrder.Models;

namespace SalesOrder.Data
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<User> Users{get;set;}
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<OrderStatus> OrderStatus {  get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
