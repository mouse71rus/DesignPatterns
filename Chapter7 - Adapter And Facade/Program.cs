﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter7 - Adapter And Facade");
            Console.WriteLine();

            Adapter.MallardDuck duck = new Adapter.MallardDuck();
            Adapter.WildTurkey turkey = new Adapter.WildTurkey();

            Adapter.TurkeyAdapter adapter = new Adapter.TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says..");
            turkey.fly();
            turkey.gobble();

            Console.WriteLine();
            Console.WriteLine("The Duck says..");
            TestMethod(duck);

            Console.WriteLine();
            Console.WriteLine("The TurkeyAdapter says..");
            TestMethod(adapter);

            Console.ReadKey();
        }

        private static void TestMethod(Adapter.IDuck duck)
        {
            duck.fly();
            duck.Quack();
        }
    }
}