using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Brainstorm
{
    public class BaseHunter : Hunter
    {
        public BaseHunter()
        {
            thing = new Decoy();
        }

        public override void display()
        {
            // Конкретная версия для DecoyDuck
            Console.WriteLine("I'm  Base Hunter!");
        }
    }
}
