using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8.Bad
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Suger & Milk");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
