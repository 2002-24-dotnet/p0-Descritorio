using System;
using PizzaBox.Domain.PizzaModels;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
          PizzaRepository pr = new PizzaRepository();
          OrderRepository or = new OrderRepository();
          StoreRepository sr = new StoreRepository();
          UserRepository ur = new UserRepository();
          CrustRepository cr = new CrustRepository();

          // Console.WriteLine("\nPizza names: ");
          // foreach (var i in pr.GetPizzas())
          // {
          //   Console.WriteLine(i.Name);
          // }

          // Console.WriteLine("\nOrder dates: ");
          // foreach (var i in or.GetOrders())
          // {
          //   Console.WriteLine(i.Date);
          // }

          // Console.WriteLine("\nStore addresses: ");
          // foreach (var i in sr.GetStores())
          // {
          //   Console.WriteLine(i.StoreAddress);
          // }

          // Console.WriteLine("\nUser first names: ");
          // foreach (var i in ur.GetUsers())
          // {
          //   Console.WriteLine(i.FirstName);
          // }

          // CrustRepository cr = new CrustRepository();
          // cr.Post(new Crust() 
          // {
          //   CrustId = 4, Name = "Cheesy Crust"
          // });

          foreach (var item in cr.Get())
          {
            Console.WriteLine("This is CrustId: {0}; This is CrustName: {1}", item.CrustId, item.Name);
          }
        }
    }
}
