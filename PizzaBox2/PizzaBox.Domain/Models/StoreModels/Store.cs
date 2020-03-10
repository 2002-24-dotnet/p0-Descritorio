using System;
using System.Collections.Generic;
using PizzaBox.Domain.OrderModels;

namespace PizzaBox.Domain.StoreModels
{
  public class Store
  {
    public long StoreId { get; set; }
    public string StoreAddress { get; set; }
    
    #region NAVIGATION
    public List<Order> Orders { get; set; }
    #endregion

    public Store()
    {
      StoreId = DateTime.Now.Ticks;
    }
  }
}