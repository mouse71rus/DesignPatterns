using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Good
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string GetDescription();
    }
}
