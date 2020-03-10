using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.OrderModels;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository
  {
    private static readonly PizzaBoxDbContext _or = new PizzaBoxDbContext();

    public List<Order> GetOrders()
    {
      return _or.OrderDbSet.ToList();
    }
  }
}