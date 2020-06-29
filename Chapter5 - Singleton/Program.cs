using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

            //Good.ChocolateBoiler boiler = Good.ChocolateBoiler.GetInstance();

            //boiler.Fiil();

            //Good.ChocolateBoiler boiler2 = Good.ChocolateBoiler.GetInstance();
            //boiler2.Fiil();

            Thread th = new Thread(Method1);
            th.Name = "Th1";
            th.Start();

            Thread th2 = new Thread(Method2);
            th2.Name = "Th2";
            th2.Start();

            Console.ReadKey();
        }

        private static void Method1()
        {
            Good.ChocolateBoiler boiler = Good.ChocolateBoiler.GetInstance();
            for (int i = 0; i < 10; i++)
            {
                boiler.Fiil();
                boiler.Boil();

                if (i % 2 == 0)
                {
                    boiler.Drain();
                }

                boiler.GetStatus();
                Thread.Sleep(1500);
            }
        }

        private static void Method2()
        {
            Good.ChocolateBoiler boiler = Good.ChocolateBoiler.GetInstance();
            for (int i = 0; i < 10; i++)
            {
                boiler.Fiil();
                boiler.Boil();

                if (i % 2 != 0)
                {
                    boiler.Drain();
                }

                boiler.GetStatus();
                Thread.Sleep(2500);
            }
        }
    }
}
