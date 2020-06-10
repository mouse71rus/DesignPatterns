using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8.Good
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
