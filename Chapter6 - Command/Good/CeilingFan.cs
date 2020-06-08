using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public class CeilingFan
    {
        public enum Speed
        {
            OFF,
            LOW,
            MEDIUM,
            HIGH
        }

        private string location;
        private Speed speed;

        public CeilingFan(string location)
        {
            this.location = location;
            this.speed = Speed.OFF;
        }

        public void High()
        {
            speed = Speed.HIGH;
            Console.WriteLine(location + ": CeilingFan is on High speed");
        }
        public void Medium()
        {
            speed = Speed.MEDIUM;
            Console.WriteLine(location + ": CeilingFan is on Medium speed");
        }
        public void Low()
        {
            speed = Speed.LOW;
            Console.WriteLine(location + ": CeilingFan is on Low speed");
        }
        public void Off()
        {
            speed = Speed.OFF;
            Console.WriteLine(location + ": CeilingFan is Off");
        }

        public Speed GetSpeed()
        {
            return speed;
        }
    }
}
