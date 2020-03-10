using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository 
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Pizza> GetPizzas()
    {
      return _db.PizzaDbSet.ToList();
    }

    public Pizza Get(long id)
    {
      return _db.PizzaDbSet.SingleOrDefault(p => p.PizzaId == id);
    }

    public bool Post(Pizza pizza)
    {
      _db.PizzaDbSet.Add(pizza);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Pizza pizza)
    {
      Pizza p = Get(pizza.PizzaId);

      p = pizza;
      return _db.SaveChanges() == 1;
    }
  }
}