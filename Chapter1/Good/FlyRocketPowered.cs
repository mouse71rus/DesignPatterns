using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm fucking flying with a rocket, shit!");
        }
    }
}
