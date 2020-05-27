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
        }
    }
}
