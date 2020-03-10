using System.Collections.Generic;
using System.Linq;
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

    public Store Get(long id)
    {
      return _sr.StoreDbSet.SingleOrDefault(p => p.StoreId == id);
    }

    public bool Post(Store store)
    {
      _sr.StoreDbSet.Add(store);
      return _sr.SaveChanges() == 1;
    }

    public bool Put(Store store)
    {
      Store p = Get(store.StoreId);

      p = store;
      return _sr.SaveChanges() == 1;
    }
  }
}