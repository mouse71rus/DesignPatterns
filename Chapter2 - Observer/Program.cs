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

            Chapter2.Good.WeatherData wd = new Good.WeatherData();
            Chapter2.Good.CurrentConditionsDisplay ccd = new Good.CurrentConditionsDisplay(wd);

            //симуляция получения новых данных
            wd.setMeasurements();
            wd.setMeasurements();
            wd.setMeasurements();
            wd.setMeasurements();
            wd.setMeasurements();

            Console.ReadKey();
        }
    }
}
