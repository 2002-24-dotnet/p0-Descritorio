using System;
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
            // Create
            Console.WriteLine("Inserting a new pizza");
            db.Add(new Pizza());
            db.SaveChanges();

            // Read
            Console.WriteLine("Querying for a pizza");
            var pizza = db.Pizza
                .OrderBy(b => b.PizzaId == 1)
                .First();

            // Update
            Console.WriteLine("Updating the pizza by changing TestId");
            pizza.TestId = 50;
            // pizza.Posts.Add(
            //     new Post
            //     {
            //         Title = "San Diego",
            //         Content = "Coffeeeeeee."
            //     });
            db.SaveChanges();

            var pizzas = db.Pizza.ToList();
            foreach (var item in pizzas)
            {
              Console.WriteLine(item.PizzaId);
              Console.WriteLine(item.TestId);
            }
          }
        }
    }
}
