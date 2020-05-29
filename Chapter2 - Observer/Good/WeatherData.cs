using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Good
{
    public class WeatherData : ISubject
    {
        private Random rnd;
        private List<IObserver> observers;

        private int temperature;
        private int humidity;
        private int pressure;


        public WeatherData()
        {
            observers = new List<IObserver>();
            rnd = new Random();
        }

        public void notifyObservers()
        {
            foreach (var item in observers)
            {
                // Активная доставка. Возвращаются все данные
                // При добавлении новых придется править код во многих местах
                item.Update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int ind = observers.IndexOf(o);

            if(ind >= 0)
            {
                observers.RemoveAt(ind);
            }
        }

        private void measurementsChanged()
        {
            notifyObservers();
        }

        
        /// <summary>
        /// Test method
        /// </summary>
        public void setMeasurements()
        {
            temperature = getTemperature();
            humidity = getHumidity();
            pressure = getPressure();

            measurementsChanged();
        }

        private int getTemperature()
        {
            return rnd.Next(20, 30);
        }

        private int getHumidity()
        {
            return rnd.Next(60, 80);
        }

        private int getPressure()
        {
            return rnd.Next(760, 785);
        }

    }
}
