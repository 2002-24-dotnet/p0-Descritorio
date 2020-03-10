using System;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaRepository pr = new PizzaRepository();
            foreach (var i in pr.GetPizzas())
            {
              Console.WriteLine(i);
            }

            OrderRepository or = new OrderRepository();
        }
    }
}
