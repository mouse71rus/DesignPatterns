using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Good
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark roast";
        }

        public override decimal Cost()
        {
            return 99.99m;
        }
    }
}
