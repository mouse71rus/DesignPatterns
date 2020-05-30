using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Good
{
    public class Milk : CondimentDecorator
    {
        public Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal Cost()
        {
            return 5m + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }
}
