using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Good
{
    class Soy : CondimentDecorator
    {
        protected Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal Cost()
        {
            return beverage.Cost() + 5m;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
