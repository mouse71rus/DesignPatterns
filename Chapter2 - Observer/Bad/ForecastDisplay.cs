using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Bad
{
    class ForecastDisplay : IDisplay
    {
        public void Update(int temperature, int humidity, int pressure)
        {
            Random rnd = new Random();
            temperature += rnd.Next(-3, 3);
            humidity += rnd.Next(-10, 10);
            pressure += rnd.Next(-10, 10);
            Console.WriteLine("My Forecast is.. {0} {1} {2}", temperature, humidity, pressure);
        }
    }
}
