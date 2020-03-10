using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Crust> Get()
    {
      return _db.CrustDbSet.ToList();
    }

    public Crust Get(long id)
    {
      return _db.CrustDbSet.SingleOrDefault(p => p.CrustId == id);
    }

    public bool Post(Crust Crust)
    {
      _db.CrustDbSet.Add(Crust);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Crust Crust)
    {
      Crust p = Get(Crust.CrustId);

      p = Crust;
      return _db.SaveChanges() == 1;
    }
  }
}