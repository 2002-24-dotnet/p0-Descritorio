using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository 
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Pizza> GetPizzas()
    {
      PizzaBoxDbContext PizzaBoxDbContext = new PizzaBoxDbContext();
      return _db.PizzaDbSet.Include(p => p.PizzaId).Include(p => p.Name).Include(p => p.Crust.CrustId).Include(p => p.Size.SizeId).ToList();
    }
  }
}