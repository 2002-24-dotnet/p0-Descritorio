using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.StoreModels;

namespace PizzaBox.Storing.Databases
{
  public class StoreDbContext : DbContext
  {
    public DbSet<Store> StoreDbSet { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Store>().HasKey(s => s.StoreId);
      builder.Entity<Store>().HasMany(u => u.Orders).WithOne(o => o.Store);
      builder.Entity<Store>().Property(u => u.StoreId).ValueGeneratedNever();
      builder.Entity<Store>().HasData(new Store[]
      {
        new Store() { StoreId = 1, StoreAddress = "Street 1"},
        new Store() { StoreId = 2, StoreAddress = "Street 2"},
        new Store() { StoreId = 3, StoreAddress = "Street 3"},
      });

    }
  }
}