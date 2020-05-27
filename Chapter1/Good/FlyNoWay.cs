using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            // Для уток, которые летать не умеют
            Console.WriteLine("I can't fly :(");
        }
    }
}
