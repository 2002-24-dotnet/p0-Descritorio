using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.OrderModels;

namespace PizzaBox.Storing.Databases
{
  public class OrderDbContext : DbContext
  {
    public DbSet<Order> OrderDbSet { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Order>().HasKey(o => o.OrderId);
      builder.Entity<Order>().Property(o => o.OrderId).ValueGeneratedNever();
      builder.Entity<Order>().HasData(new Order[]
      {
        new Order() { OrderId = 1, StoreId = 3, UserId = 1},
        new Order() { OrderId = 2, StoreId = 2, UserId = 2},
        new Order() { OrderId = 3, StoreId = 1, UserId = 3},
      });
    }
  }
}