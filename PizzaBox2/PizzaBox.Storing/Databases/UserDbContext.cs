using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.UserModels;

namespace PizzaBox.Storing.Databases
{
  public class UserDbContext : DbContext
  {
    public DbSet<User> UserDbSet { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>().HasKey(u => u.UserId);
      builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
      builder.Entity<User>().Property(u => u.UserId).ValueGeneratedNever();
      builder.Entity<User>().HasData(new User[]
      {
        new User() { UserId = 1, FirstName = "Bob", LastName = "Builder"},
        new User() { UserId = 2, FirstName = "Fred", LastName = "Flintstone"},
        new User() { UserId = 3, FirstName = "Cat", LastName = "Kansas"}
      });
    }
  }
}