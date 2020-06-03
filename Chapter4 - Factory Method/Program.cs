using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter4 - Factory Method");
            Console.WriteLine();

            Good.PizzaStore NYStore = new Good.NYStylePizzaStore();
            Good.Pizza pizza = NYStore.Order("Cheese");
            Console.WriteLine("Person 1 ordered a NY style: " + pizza.GetName());
            Console.WriteLine();
            Good.PizzaStore ChicagoStore = new Good.ChicagoStylePizzaStore();
            Good.Pizza pizza2 = ChicagoStore.Order("Cheese");
            Console.WriteLine("Person 2 ordered a NY style: " + pizza2.GetName());

            Console.ReadKey();
        }
    }
}
