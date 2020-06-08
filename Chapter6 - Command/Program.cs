using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter6 - Command");
            Console.WriteLine();

            Good.SimpleRemoteControl remote = new Good.SimpleRemoteControl();
            Good.Light light = new Good.Light();
            Good.LightOnCommand lightOn = new Good.LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
