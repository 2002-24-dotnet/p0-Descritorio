using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Topping> GetToppings()
    {
      return _db.ToppingDbSet.Include(t => t.ToppingId).Include(t => t.Name).ToList();
    }
  }
}