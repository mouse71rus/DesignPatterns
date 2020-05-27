using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            // Реализация кряканья
            Console.WriteLine("Quack");
        }
    }
}
