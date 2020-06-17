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

            IteratorAndComposite.Flock flockOfDucks = new IteratorAndComposite.Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(goose);

            IteratorAndComposite.Flock flockOfMallardDuck = new IteratorAndComposite.Flock();
            var mallardOne = duckFactory.CreateMallardDuck();
            var mallardTwo = duckFactory.CreateMallardDuck();
            var mallardThree = duckFactory.CreateMallardDuck();
            var mallardFour = duckFactory.CreateMallardDuck();
            flockOfMallardDuck.Add(mallardOne);
            flockOfMallardDuck.Add(mallardTwo);
            flockOfMallardDuck.Add(mallardThree);
            flockOfMallardDuck.Add(mallardFour);
            flockOfDucks.Add(flockOfMallardDuck);

            Console.WriteLine("Duck simulator:");

            Simulate(flockOfDucks);
            Console.WriteLine();
            Simulate(flockOfMallardDuck);

            Console.WriteLine($"\nThe ducks quacked {Decorator.QuackCounter.GetCount()} times");
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
