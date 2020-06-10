using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            Console.ReadKey();
        }
    }
}
