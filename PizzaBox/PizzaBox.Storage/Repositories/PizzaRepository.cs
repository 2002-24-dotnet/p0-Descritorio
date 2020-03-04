using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository
  {
    public List<Pizza> Get()
    {
      return new List<Pizza>()
      {
        new Pizza(),
        new Pizza(),
        new Pizza()
      };
    }
  }
}