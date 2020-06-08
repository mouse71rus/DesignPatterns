using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7.Adapter
{
    public class MallardDuck : IDuck
    {
        public void fly()
        {
            Console.WriteLine("I am flying!");
        }

        public void Quack()
        {
            Console.WriteLine("*Quack*");
        }
    }
}
