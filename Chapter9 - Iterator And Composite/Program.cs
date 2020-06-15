using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter9 - Iterator And Composite");
            Console.WriteLine();

            var menus = new List<Iterator.IMenu>();
            menus.Add(new Iterator.PancakeHouseMenu());
            menus.Add(new Iterator.DinerMenu());

            Iterator.Waitress waitress = new Iterator.Waitress(menus);
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
