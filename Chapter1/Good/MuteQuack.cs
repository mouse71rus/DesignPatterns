using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            // Утки, которые не издают звуков
            Console.WriteLine("...");
        }
    }
}
