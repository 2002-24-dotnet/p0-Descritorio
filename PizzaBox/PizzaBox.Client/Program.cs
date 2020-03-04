using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
  class Program
  {
    private static readonly PizzaRepository _pr = new PizzaRepository();
    private static void Main(string[] args)
    {
      GetAllPizzas();
    }
    private static void GetAllPizzas()
    {
      foreach (var p in _pr.Get())
      {
        Console.WriteLine(p.crust);
      }
      
    }
  }
}
