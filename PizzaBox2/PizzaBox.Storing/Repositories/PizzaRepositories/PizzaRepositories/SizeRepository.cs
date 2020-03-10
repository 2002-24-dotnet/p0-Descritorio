using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class SizeRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Size> GetSize()
    {
      return _db.SizeDbSet.ToList();
    }
  }
}