using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(),
                new BlackCoffee(),
                new Latte()

            };

            List<Coffee> milkList = new List<Coffee>();
            {
                foreach (var coffee in orderList)
                {
                    if (coffee is Milk) milkList.Add(coffee);
                }
            }
           


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ (coffee.price() - coffee.discount()));
            }

            foreach (var coffee in milkList)
            {
                Console.WriteLine("the coffee with milks : " + coffee.name() );
            }

        }
    }
}
