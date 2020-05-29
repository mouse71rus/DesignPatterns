using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Bad
{
    class DarkRoastWithWhipAndSoy : Beverage
    {
        public override decimal Cost()
        {
            decimal Whip = 10m;
            decimal Soy = 5m;
            decimal Decaf = 99.99m;

            return Whip + Soy + Decaf;
        }
    }
}
