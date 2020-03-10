﻿using System;
using PizzaBox.Storing.Repositories.PizzaRepositories;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaRepository pr = new PizzaRepository();
            foreach (var i in pr.GetPizzas())
            {
              Console.WriteLine(i.PizzaId);
            }
        }
    }
}
