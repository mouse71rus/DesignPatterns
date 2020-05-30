using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Good
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override decimal Cost()
        {
            return 149.90m;
        }
    }
}
