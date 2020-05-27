using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            // Резиновые утки пищат
            Console.WriteLine("Squeak");
        }
    }
}
