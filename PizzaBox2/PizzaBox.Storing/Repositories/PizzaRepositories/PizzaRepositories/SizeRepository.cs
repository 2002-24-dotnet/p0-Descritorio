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

    public Size Get(long id)
    {
      return _db.SizeDbSet.SingleOrDefault(p => p.SizeId == id);
    }

    public bool Post(Size Size)
    {
      _db.SizeDbSet.Add(Size);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Size Size)
    {
      Size p = Get(Size.SizeId);

      p = Size;
      return _db.SaveChanges() == 1;
    }
  }
}