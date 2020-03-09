using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public long PizzaId { get; set; }
    
    #region NAVIGATIONAL PROPERTIES

    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public virtual List<Topping> Toppings { get; set; }

    #endregion

    public Pizza()
    {
      this.Toppings = new List<Topping>();
    }

  }
}