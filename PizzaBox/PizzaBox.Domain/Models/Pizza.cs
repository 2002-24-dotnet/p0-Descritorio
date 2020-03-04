namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public string crust;
    public string sauce;
    public string cheese;
    public string size;

    public Pizza()
    {
      this.crust = "Traditional";
      this.sauce = "Tomato";
      this.cheese = "Mozzarella";
      this.size = "Medium";
    }
  }
}