using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.OrderModels;
using PizzaBox.Domain.StoreModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class StoreRepository
  {
    private static readonly PizzaBoxDbContext _sr = new PizzaBoxDbContext();

    public List<Store> GetStores()
    {
      return _sr.StoreDbSet.ToList();
    }
  }
}