using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8.Good
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void AddCondiments();
        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
