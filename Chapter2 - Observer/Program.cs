using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter2 - Observer");
            Console.WriteLine();

            Chapter2.Bad.WeatherData wd = new Bad.WeatherData(
                new Bad.CurrentConditionsDisplay(), 
                new Bad.StatisticsDisplay(), 
                new Bad.ForecastDisplay()
            );

            //симуляция получения новых данных
            wd.measurementsChanged();
            wd.measurementsChanged();
            wd.measurementsChanged();
            wd.measurementsChanged();
            wd.measurementsChanged();

            Console.ReadKey();
        }
    }
}
