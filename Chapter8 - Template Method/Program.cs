using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter8.Good;

namespace Chapter8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Chapter8 - Template Method");
            Console.WriteLine();

            Good.Tea tea = new Good.Tea();
            Console.WriteLine("Tea");
            tea.PrepareRecipe();
            Console.WriteLine();

            Good.Coffee coffee = new Good.Coffee();
            Console.WriteLine("Coffee");
            coffee.PrepareRecipe();


            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sort:");
            Console.WriteLine();
            Good.Duck[] ducks = new Good.Duck[] {
                new Good.Duck("Howard", 5),
                new Good.Duck("Marry", 7),
                new Good.Duck("Andrew", 6),
                new Good.Duck("Sergey", 4),
                new Good.Duck("Max", 8),
                new Good.Duck("Sashko", 2),
                new Good.Duck("Forward", 7),
            };
            Console.WriteLine("Before: ");
            Console.WriteLine();
            display(ducks);

            Console.WriteLine();
            Console.WriteLine("After: ");
            Console.WriteLine();

            Array.Sort(ducks);
            display(ducks);
            Console.WriteLine("--------------------------");

            Console.ReadKey();
        }

        private static void display(Duck[] ducks)
        {
            foreach (var item in ducks)
            {
                Console.WriteLine($"{item.Name} {item.Weight}");
            }
        }
    }
}
