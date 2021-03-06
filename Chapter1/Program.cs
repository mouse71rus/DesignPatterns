﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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


            // Chapter6 - Command
            Chapter6.Program.Main(args);


            // Chapter7 - Adapter And Facade
            Chapter7.Program.Main(args);


            // Chapter8 - Template Method
            Chapter8.Program.Main(args);


            // Chapter9 - Iterator And Composite
            Chapter9.Program.Main(args);


            // Chapter10 - State
            Chapter10.Program.Main(args);


            // Chapter11 - Proxy
            Chapter11.Program.Main(args);


            // Chapter12 - Pattern Of Patterns - Combining
            Chapter12.Program.Main(args);


            // Chapter12 - Pattern Of Patterns - MVC
            Chapter12.MVC.Program.Main();
        }
    }
}