using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter3 - Decorator");
            Console.WriteLine();

            Bad.Beverage expresso = new Bad.Espresso();
            Console.WriteLine(expresso.GetDescription());
            Bad.Beverage houseBlend = new Bad.HouseBlend();
            Console.WriteLine(houseBlend.GetDescription());
            Bad.Beverage decaf = new Bad.Decaf();
            decaf.setMilk(true);
            decaf.setSoy(true);
            Console.WriteLine(decaf.GetDescription());
            Bad.Beverage darkRoast = new Bad.DarkRoast();
            Console.WriteLine(darkRoast.GetDescription());

            Console.ReadKey();
        }
    }
}
