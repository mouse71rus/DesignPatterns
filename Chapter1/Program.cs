using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Chapter2;
using Chapter3;
using Chapter4;
namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter1 - Strategy");
            Console.WriteLine();

            Good.Duck mallard = new Good.MallardDuck();
            mallard.display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.WriteLine();

            Good.Duck decoy = new Good.DecoyDuck();
            decoy.display();
            decoy.PerformFly();
            decoy.PerformQuack();

            decoy.setFlyBehavior(new Good.FlyRocketPowered());
            decoy.PerformFly();

            Console.WriteLine();

            Brainstorm.Hunter baseHunter = new Brainstorm.BaseHunter();
            Console.WriteLine("Hello!");
            baseHunter.display();
            baseHunter.PerformUseThing();
            

            Console.ReadKey();


            // Chapter2 - Observer
            Chapter2.Program.Main(args);


            // Chapter3 - Decorator
            Chapter3.Program.Main(args);


            // Chapter4 - Factory Method
            Chapter4.Program.Main(args);

            // Chapter5 - Singleton
            Chapter5.Program.Main(args);
        }
    }
}
