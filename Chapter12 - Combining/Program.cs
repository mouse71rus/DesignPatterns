using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Chapter12 - Pattern Of Patterns - Combining");
            Console.WriteLine();
            AbstractFactory.AbstractFactory duckFactory = new AbstractFactory.CountingDuckFactory();
            Simulate(duckFactory);
            

            Console.ReadKey();
        }

        private static void Simulate(AbstractFactory.AbstractFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable goose = duckFactory.CreateGoose();

            Console.WriteLine("Duck simulator:");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(goose);

            Console.WriteLine($"\nThe ducks quacked {Decorator.QuackCounter.GetCount()} times");
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
