using System;

namespace Chapter7.Facade
{
    public class TheaterLights
    {
        internal void Dim(int v)
        {
            Console.WriteLine($"Theater Ceiling lights diming to {v}%");
        }

        internal void On()
        {
            Console.WriteLine($"Theater Ceiling lights on");
        }
    }
}