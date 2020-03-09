using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class APizzaComponent
  {
    public string Name { get; set; }

    #region NAVIGATIONAL PROPERTIES

    public Pizza Pizza { get; set; }
    public long PizzaId { get; set; }

    #endregion
  }
}
