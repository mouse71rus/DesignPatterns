using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public abstract void display();
    }
}
