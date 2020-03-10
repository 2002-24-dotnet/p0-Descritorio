using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.PizzaModels
{
  public class Topping
  {
    public long ToppingId { get; set; }
    public string Name { get; set; }
    
    #region NAVIGATION
    public List<PizzaTopping> PizzaTopping { get; set; }
    #endregion

    public Topping(){}
  }
}