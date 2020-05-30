using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Good
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";


        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract decimal Cost();
    }
}
