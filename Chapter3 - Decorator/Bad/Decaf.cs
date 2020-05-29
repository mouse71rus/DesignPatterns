using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Bad
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override decimal Cost()
        {
            decimal res = 0m;

            if (hasMilk())
            {
                res += 10m;
            }
            if (hasSoy())
            {
                res += 5m;
            }
            if (hasMocha())
            {
                res += 12m;
            }
            if (hasWhip())
            {
                res += 7;
            }

            return res + 149.90m;
        }
    }
}
