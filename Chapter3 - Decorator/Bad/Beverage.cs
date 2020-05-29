using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.Bad
{
    public abstract class Beverage
    {
        protected string Description;

        protected bool milk = false;
        protected bool soy = false;
        protected bool mocha = false;
        protected bool whip = false;

        public bool hasMilk()
        {
            return milk;
        }
        public void setMilk(bool m)
        {
            milk = m;
        }

        public bool hasSoy()
        {
            return soy;
        }
        public void setSoy(bool s)
        {
            soy = s;
        }

        public bool hasMocha()
        {
            return mocha;
        }
        public void setMocha(bool m)
        {
            mocha = m;
        }

        public bool hasWhip()
        {
            return whip;
        }
        public void setWhip(bool w)
        {
            whip = w;
        }

        public string GetDescription()
        {
            return Description + " Cost: " + Cost();
        }

        public abstract decimal Cost();
    }
}
