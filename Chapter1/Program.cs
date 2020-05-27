using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Good.Duck mallard = new Good.MallardDuck();
            mallard.display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.ReadKey();
        }
    }
}
