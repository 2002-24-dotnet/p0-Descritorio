using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.PizzaModels;

namespace PizzaBox.Storing.Databases
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Crust> CrustDbSet { get; set; }
    public DbSet<Pizza> PizzaDbSet { get; set; }
    public DbSet<Pizza> PizzaToppingDbSet { get; set; }
    public DbSet<Size> SizeDbSet { get; set; }
    public DbSet<Topping> ToppingDbSet { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
    {
      modelBuilder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(c => c.CrustId);
      builder.Entity<Pizza>().HasKey(p => p.PizzaId);
      builder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
      builder.Entity<Size>().HasKey(s => s.SizeId);
      builder.Entity<Topping>().HasKey(t => t.ToppingId);

      builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.Crust);
      builder.Entity<Pizza>().HasMany(p => p.PizzaTopping).WithOne(pt => pt.Pizza).HasForeignKey(pt => pt.PizzaId);
      builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.Size);
      builder.Entity<Topping>().HasMany(t => t.PizzaTopping).WithOne(pt => pt.Topping).HasForeignKey(pt => pt.ToppingId);

      // builder.Entity<PizzaTopping>()
      //   .HasOne(pt => pt.Pizza)
      //   .WithMany(p => p.PizzaTopping)
      //   .HasForeignKey(pt => pt.PizzaId);

      // builder.Entity<PizzaTopping>()
      //   .HasOne(pt => pt.Topping)
      //   .WithMany(t => t.PizzaTopping)
      //   .HasForeignKey(pt => pt.ToppingId);

      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() { CrustId = 1, Name = "Deep Dish"},
        new Crust() { CrustId = 2, Name = "New York Style"},
        new Crust() { CrustId = 3, Name = "Thin Crust"}
      });

      builder.Entity<Pizza>().HasData(new Pizza[]
      {
        new Pizza() { PizzaId = 1, Name = "The Dominic"},
        new Pizza() { PizzaId = 2, Name = "The Fred"},
        new Pizza() { PizzaId = 3, Name = "The Enthusiast"},
      });

      builder.Entity<PizzaTopping>().HasData(new PizzaTopping[]
      {
        new PizzaTopping() { PizzaId = 1, ToppingId = 1},
        new PizzaTopping() { PizzaId = 2, ToppingId = 1},
        new PizzaTopping() { PizzaId = 3, ToppingId = 1},
      });

      builder.Entity<Size>().HasData(new Size[]
      {
        new Size() { SizeId = 1, Name = "Large"},
        new Size() { SizeId = 2, Name = "Medium"},
        new Size() { SizeId = 3, Name = "Small"},
      });

      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping() { ToppingId = 1, Name = "Cheese"},
        new Topping() { ToppingId = 2, Name = "Pepperoni"},
        new Topping() { ToppingId = 3, Name = "Tomato Sauce"},
      });

    }
  }
}