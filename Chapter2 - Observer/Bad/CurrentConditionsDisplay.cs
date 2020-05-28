using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Bad
{
    class CurrentConditionsDisplay : IDisplay
    {
        public void Update(int temperature, int humidity, int pressure)
        {
            Console.WriteLine("Current measurements are.. {0} {1} {2}", temperature, humidity, pressure);
        }
    }
}
