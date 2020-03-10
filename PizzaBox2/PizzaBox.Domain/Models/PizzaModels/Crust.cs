using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.PizzaModels
{
  public class Crust
  {
    public long CrustId { get; set; }
    public string Name { get; set; }
    
    #region NAVIGATION
    public List<Pizza> Pizzas { get; set; }
    #endregion

    public Crust(){}
  }
}