using System;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPizza names: ");
            PizzaRepository pr = new PizzaRepository();
            foreach (var i in pr.GetPizzas())
            {
              Console.WriteLine(i.Name);
            }

            Console.WriteLine("\nOrder dates: ");
            OrderRepository or = new OrderRepository();
            foreach (var i in or.GetOrders())
            {
              Console.WriteLine(i.Date);
            }

            Console.WriteLine("\nStore addresses: ");
            StoreRepository sr = new StoreRepository();
            foreach (var i in sr.GetStores())
            {
              Console.WriteLine(i.StoreAddress);
            }

            Console.WriteLine("\nUser first names: ");
            UserRepository ur = new UserRepository();
            foreach (var i in ur.GetUsers())
            {
              Console.WriteLine(i.FirstName);
            }
        }
    }
}
