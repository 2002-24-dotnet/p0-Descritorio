using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.PizzaModels
{
  public class Pizza
  {
    public long PizzaId { get; set; }
    public string Name { get; set; }
    
    #region NAVIGATION
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<PizzaTopping> PizzaTopping { get; set; }
    //public Order Order { get; set; }
    #endregion

    public Pizza(){}

    public override string ToString()
    {
      return $"{PizzaId} {Name ?? "N/A"} {Crust.Name ?? "N/A"} {Size.Name ?? "N/A"} {PizzaTopping.Count}";
    }
  }
}