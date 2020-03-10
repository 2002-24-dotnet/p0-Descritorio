using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.OrderModels;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Domain.StoreModels;
using PizzaBox.Domain.UserModels;

namespace PizzaBox.Storing.Databases
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Crust> CrustDbSet { get; set; }
    public DbSet<Pizza> PizzaDbSet { get; set; }
    public DbSet<PizzaTopping> PizzaToppingDbSet { get; set; }
    public DbSet<Size> SizeDbSet { get; set; }
    public DbSet<Topping> ToppingDbSet { get; set; }

    public DbSet<Order> OrderDbSet { get; set; }
    public DbSet<Store> StoreDbSet { get; set; }
    public DbSet<User> UserDbSet { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
    {
      modelBuilder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      // builder.Entity<PizzaTopping>()
      //   .HasOne(pt => pt.Pizza)
      //   .WithMany(p => p.PizzaTopping)
      //   .HasForeignKey(pt => pt.PizzaId);

      // builder.Entity<PizzaTopping>()
      //   .HasOne(pt => pt.Topping)
      //   .WithMany(t => t.PizzaTopping)
      //   .HasForeignKey(pt => pt.ToppingId);

      #region PIZZA
      builder.Entity<Crust>().HasKey(c => c.CrustId);
      builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.Crust);
      builder.Entity<Crust>().Property(c => c.CrustId).ValueGeneratedNever();
      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() { CrustId = 1, Name = "Deep Dish"},
        new Crust() { CrustId = 2, Name = "New York Style"},
        new Crust() { CrustId = 3, Name = "Thin Crust"}
      });

      builder.Entity<Pizza>().HasKey(p => p.PizzaId);
      builder.Entity<Pizza>().HasMany(p => p.PizzaTopping).WithOne(pt => pt.Pizza).HasForeignKey(pt => pt.PizzaId);
      builder.Entity<Pizza>().Property(p => p.PizzaId).ValueGeneratedNever();
      builder.Entity<Pizza>().HasData(new Pizza[]
      {
        new Pizza() { PizzaId = 1, Name = "The Dominic"},
        new Pizza() { PizzaId = 2, Name = "The Fred"},
        new Pizza() { PizzaId = 3, Name = "The Enthusiast"},
      });

      builder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
      builder.Entity<PizzaTopping>().HasData(new PizzaTopping[]
      {
        new PizzaTopping() { PizzaId = 1, ToppingId = 1},
        new PizzaTopping() { PizzaId = 2, ToppingId = 1},
        new PizzaTopping() { PizzaId = 3, ToppingId = 1},
      });

      builder.Entity<Size>().HasKey(s => s.SizeId);
      builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.Size);
      builder.Entity<Size>().Property(s => s.SizeId).ValueGeneratedNever();
      builder.Entity<Size>().HasData(new Size[]
      {
        new Size() { SizeId = 1, Name = "Large"},
        new Size() { SizeId = 2, Name = "Medium"},
        new Size() { SizeId = 3, Name = "Small"},
      });

      builder.Entity<Topping>().HasKey(t => t.ToppingId);
      builder.Entity<Topping>().HasMany(t => t.PizzaTopping).WithOne(pt => pt.Topping).HasForeignKey(pt => pt.ToppingId);
      builder.Entity<Topping>().Property(t => t.ToppingId).ValueGeneratedNever();
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping() { ToppingId = 1, Name = "Cheese"},
        new Topping() { ToppingId = 2, Name = "Pepperoni"},
        new Topping() { ToppingId = 3, Name = "Tomato Sauce"},
      });
      #endregion

      #region ORDER
      builder.Entity<Order>().HasKey(o => o.OrderId);
      builder.Entity<Order>().Property(o => o.OrderId).ValueGeneratedNever();
      builder.Entity<Order>().HasData(new Order[]
      {
        new Order() { OrderId = 1, StoreId = 3, UserId = 1},
        new Order() { OrderId = 2, StoreId = 2, UserId = 2},
        new Order() { OrderId = 3, StoreId = 1, UserId = 3},
      });
      #endregion

      #region STORE
      builder.Entity<Store>().HasKey(s => s.StoreId);
      builder.Entity<Store>().HasMany(u => u.Orders).WithOne(o => o.Store);
      builder.Entity<Store>().Property(u => u.StoreId).ValueGeneratedNever();
      builder.Entity<Store>().HasData(new Store[]
      {
        new Store() { StoreId = 1, StoreAddress = "Street 1"},
        new Store() { StoreId = 2, StoreAddress = "Street 2"},
        new Store() { StoreId = 3, StoreAddress = "Street 3"},
      });
      #endregion

      #region USER
      builder.Entity<User>().HasKey(u => u.UserId);
      builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
      builder.Entity<User>().Property(u => u.UserId).ValueGeneratedNever();
      builder.Entity<User>().HasData(new User[]
      {
        new User() { UserId = 1, FirstName = "Bob", LastName = "Builder"},
        new User() { UserId = 2, FirstName = "Fred", LastName = "Flintstone"},
        new User() { UserId = 3, FirstName = "Cat", LastName = "Kansas"}
      });
      #endregion
    }
  }
}