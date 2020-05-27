using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Brainstorm
{
    public class Decoy : IThing
    {
        public void Use()
        {
            Console.WriteLine("Using.. *Quack-Quack*");
        }
    }
}
