using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Bad
{
    public abstract class Beverage
    {
        protected string Description;

        public string GetDescription()
        {
            return Description + " Cost: " + Cost();
        }

        public abstract decimal Cost();
    }
}
