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

            Simulate();
            

            Console.ReadKey();
        }

        private static void Simulate()
        {
            IQuackable mallardDuck = new MallardDuck();
            IQuackable redheadDuck = new RedheadDuck();
            IQuackable duckCall = new DuckCall();
            IQuackable rubberDuck = new RubberDuck();
            IQuackable goose = new Adapter.GooseAdapter(new Adapter.Goose());

            Console.WriteLine("Duck simulator:");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(goose);
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
