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

            Good.Beverage expresso = new Good.Espresso();
            Console.WriteLine(expresso.GetDescription());



            Good.Beverage houseBlend = new Good.HouseBlend();
            Console.WriteLine(houseBlend.GetDescription() + " Cost: " + houseBlend.Cost());
            houseBlend = new Good.Milk(houseBlend);

            var a = houseBlend as Good.Milk; // Эта строка обязательна, иначе не работает
            Console.WriteLine(a.GetDescription() + " Cost: " + houseBlend.Cost());


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
