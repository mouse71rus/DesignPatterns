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

            Good.RemoteControl rc = new Good.RemoteControl();
            Console.WriteLine(rc.ToString());

            Good.Light lightInBedroom = new Good.Light();
            Good.LightOnCommand lightInBedroom_OnCommand = new Good.LightOnCommand(lightInBedroom);
            Good.LightOffCommand lightInBedroom_OffCommand = new Good.LightOffCommand(lightInBedroom);
            Good.Stereo myStereo = new Good.Stereo();
            Good.StereoOnWithCDCommand myStereo_On = new Good.StereoOnWithCDCommand(myStereo);
            Good.StereoOffWithCDCommand myStereo_Off = new Good.StereoOffWithCDCommand(myStereo);

            rc.SetCommand(0, lightInBedroom_OnCommand, lightInBedroom_OffCommand);
            rc.SetCommand(1, myStereo_On, myStereo_Off);

            Console.WriteLine(rc.ToString());

            rc.OnButtonWasPressed(0);
            rc.OnButtonWasPressed(1);
            rc.OffButtonWasPressed(0);
            rc.UndoButtonWasPressed();

            Console.WriteLine(rc.ToString());

            Console.ReadKey();
        }
    }
}
