using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Good
{
    class CurrentConditionsDisplay : IDisplay, IObserver
    {
        private int temperature;
        private int humidity;
        private int pressure;

        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData wd)
        {
            _weatherData = wd;
            _weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current measurements are.. {0} {1} {2}", temperature, humidity, pressure);
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            display();
        }
    }
}
