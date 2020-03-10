using System;
using System.Collections.Generic;
using PizzaBox.Domain.OrderModels;

namespace PizzaBox.Domain.UserModels
{
  public class User
  {
    public long UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    #region NAVIGATION
    public List<Order> Orders { get; set; }
    #endregion

    public User()
    {
      UserId = DateTime.Now.Ticks;
    }
  }
}