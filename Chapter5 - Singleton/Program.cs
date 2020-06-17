using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Chapter5 - Singleton");
            Console.WriteLine();

            Good.ChocolateBoiler boiler = Good.ChocolateBoiler.GetInstance();

            boiler.Fiil();

            Good.ChocolateBoiler boiler2 = Good.ChocolateBoiler.GetInstance();
            boiler2.Fiil();

            Console.ReadKey();
        }
    }
}
