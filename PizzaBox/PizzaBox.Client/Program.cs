using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Databases;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
          using (var db = new PizzaBoxDbContext())
          {
            var pizza = new Pizza() {PizzaId = 1};
            var size = new Size() {Name = "SomeSize"};
            var toppingA = new Topping() {Name = "Apple"};
            var toppingB = new Topping() {Name = "Banana"};

            pizza.Crust.Name = "SomeCrust";
            pizza.Size.Name = "SomeSize";
            pizza.Toppings.Add(toppingA);
            pizza.Toppings.Add(toppingB);

            db.Pizza.Add(pizza);
            db.SaveChanges();



          }
        }
    }
}
