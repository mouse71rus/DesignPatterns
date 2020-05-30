using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Good
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend";
        }

        public override decimal Cost()
        {
            return 69.99m;
        }
    }
}
