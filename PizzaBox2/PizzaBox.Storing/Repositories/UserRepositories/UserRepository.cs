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

    public User Get(long id)
    {
      return _ur.UserDbSet.SingleOrDefault(p => p.UserId == id);
    }

    public bool Post(User user)
    {
      _ur.UserDbSet.Add(user);
      return _ur.SaveChanges() == 1;
    }

    public bool Put(User user)
    {
      User p = Get(user.UserId);

      p = user;
      return _ur.SaveChanges() == 1;
    }
  }
}