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

    public Order Get(long id)
    {
      return _or.OrderDbSet.SingleOrDefault(p => p.OrderId == id);
    }

    public bool Post(Order order)
    {
      _or.OrderDbSet.Add(order);
      return _or.SaveChanges() == 1;
    }

    public bool Put(Order order)
    {
      Order p = Get(order.OrderId);

      p = order;
      return _or.SaveChanges() == 1;
    }
  }
}