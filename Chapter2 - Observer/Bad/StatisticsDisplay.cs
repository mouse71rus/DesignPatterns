using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Bad
{
    class StatisticsDisplay : IDisplay
    {
        private List<int> temperatures = new List<int>();
        private List<int> humidities = new List<int>();
        private List<int> pressures = new List<int>();
        public void Update(int temperature, int humidity, int pressure)
        {
            temperatures.Add(temperature);
            humidities.Add(humidity);
            pressures.Add(pressure);

            Console.WriteLine();
            Console.WriteLine("Statistics.. ");
            for (int i = 0; i < temperatures.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", temperatures[i], humidities[i], pressures[i]);
            }
            Console.WriteLine();
            
        }
    }
}
