using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            // Конкретная версия для DecoyDuck
            Console.WriteLine("I'm  DecoyDuck Duck!");
        }
    }
}
