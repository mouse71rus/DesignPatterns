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

            Iterator.Waitress waitress = new Iterator.Waitress(new Iterator.PancakeHouseMenu(), new Iterator.DinerMenu());
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
