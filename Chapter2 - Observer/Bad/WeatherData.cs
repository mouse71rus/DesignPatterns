using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Bad
{
    public class WeatherData
    {
        private IDisplay currentConditionsDisplay;
        private IDisplay statisticsDisplay;
        private IDisplay forecastDisplay;

        private Random rnd = new Random();

        public WeatherData(IDisplay currentConditionsDisplay, IDisplay statisticsDisplay, IDisplay forecastDisplay)
        {
            this.currentConditionsDisplay = currentConditionsDisplay;
            this.statisticsDisplay = statisticsDisplay;
            this.forecastDisplay = forecastDisplay;
        }

        public int getTemperature()
        {
            return rnd.Next(20, 30);
        }

        public int getHumidity()
        {
            return rnd.Next(60, 80);
        }

        public int getPressure()
        {
            return rnd.Next(760, 785);
        }

        public void measurementsChanged()
        {
            int temp = getTemperature();
            int hum = getHumidity();
            int forecast = getPressure();

            currentConditionsDisplay.Update(temp, hum, forecast);
            statisticsDisplay.Update(temp, hum, forecast);
            forecastDisplay.Update(temp, hum, forecast);
        }
    }
}
