using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.UserModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class UserRepository
  {
    private static readonly PizzaBoxDbContext _ur = new PizzaBoxDbContext();

    public List<User> GetUsers()
    {
      return _ur.UserDbSet.ToList();
    }
  }
}