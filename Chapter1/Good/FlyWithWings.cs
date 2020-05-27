using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Good
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            // Реализация полёта
            // Для всех летающих уток
            Console.WriteLine("I'm flying");
        }
    }
}
