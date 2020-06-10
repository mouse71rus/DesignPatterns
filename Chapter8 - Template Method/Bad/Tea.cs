using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8.Bad
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

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
