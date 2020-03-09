using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Databases
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Crust> Crust { get; set; }
    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Topping> Topping { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pizza>()
      .HasOne(c => c.Crust)
      .WithOne(p => p.Pizza)
      .HasForeignKey<Crust>(c => c.CrustId);

      builder.Entity<Pizza>()
      .HasOne(s => s.Size)
      .WithOne(p => p.Pizza)
      .HasForeignKey<Size>(s => s.SizeId);

      builder.Entity<PizzaTopping>()
            .HasOne(pt => pt.Pizza)
            .WithMany(p => p.PizzaToppings)
            .HasForeignKey(pt => pt.PizzaId);

      builder.Entity<PizzaTopping>()
            .HasOne(pt => pt.Topping)
            .WithMany(t => t.PizzaToppings)
            .HasForeignKey(pt => pt.ToppingId);
    }

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Crust>().HasKey(c => c.CrustId);
    //   builder.Entity<Pizza>().HasKey(p => p.PizzaId);
    //   builder.Entity<Size>().HasKey(s => s.SizeId);
    //   builder.Entity<Topping>().HasKey(t => t.ToppingId);

    //   builder.Entity<Crust>().HasMany<Pizza>().WithOne(p => p.Crust);
    //   builder.Entity<Size>().HasMany<Pizza>().WithOne(p => p.Size);
    //   builder.Entity<Topping>().HasMany<Pizza>();

    //   builder.Entity<Crust>().HasData(new Crust[]
    //   {
    //     new Crust() { Name = "Deep Dish", Price = 3.50M, CrustId = 1 },
    //     new Crust() { Name = "New York Style", Price = 2.50M, CrustId = 2 },
    //     new Crust() { Name = "Thin Crust", Price = 1.50M, CrustId = 3 }
    //   });

    //   builder.Entity<Size>().HasData(new Size[]
    //   {
    //     new Size() { Name = "Large", Price = 12.00M, SizeId = 1 },
    //     new Size() { Name = "Medium", Price = 10.00M, SizeId = 2 },
    //     new Size() { Name = "Small", Price = 8.00M, SizeId = 3 },
    //   });

    //   builder.Entity<Topping>().HasData(new Topping[]
    //   {
    //     new Topping() { Name = "Cheese", Price = 0.25M, ToppingId = 1 },
    //     new Topping() { Name = "Pepperoni", Price = 0.50M, ToppingId = 2 },
    //     new Topping() { Name = "Tomato Sauce", Price = 0.75M, ToppingId = 3 },
    //   });
    // }
  }
}