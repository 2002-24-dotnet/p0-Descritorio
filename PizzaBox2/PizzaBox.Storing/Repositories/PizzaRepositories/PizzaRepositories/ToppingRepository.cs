using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Topping> GetToppings()
    {
      return _db.ToppingDbSet.ToList();
    }

    public Topping Get(long id)
    {
      return _db.ToppingDbSet.SingleOrDefault(p => p.ToppingId == id);
    }

    public bool Post(Topping topping)
    {
      _db.ToppingDbSet.Add(topping);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Topping topping)
    {
      Topping p = Get(topping.ToppingId);

      p = topping;
      return _db.SaveChanges() == 1;
    }
  }
}