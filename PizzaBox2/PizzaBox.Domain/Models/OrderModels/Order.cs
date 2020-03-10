using System;
using System.Collections.Generic;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Domain.StoreModels;
using PizzaBox.Domain.UserModels;

namespace PizzaBox.Domain.OrderModels
{
  public class Order
  {
    public long OrderId { get; set; }
    public long Date { get; set; }
    
    #region NAVIGATION  
    public Store Store { get; set; }
    public long StoreId { get; set; } 
    public User User { get; set; }
    public long UserId { get; set; }
    public List<Pizza> Pizzas { get; set; }
    #endregion

    public Order() 
    {
      OrderId = DateTime.Now.Ticks;
      Date = DateTime.Now.Ticks;
    }
  }
}