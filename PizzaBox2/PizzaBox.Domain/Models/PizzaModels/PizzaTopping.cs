namespace PizzaBox.Domain.PizzaModels
{
  public class PizzaTopping
  {
    public Pizza Pizza { get; set; }
    public long PizzaId { get; set; }
    public Topping Topping { get; set; }
    public long ToppingId { get; set; }
  }
}