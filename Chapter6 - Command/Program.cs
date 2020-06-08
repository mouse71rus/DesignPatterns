using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter6.Good;
namespace Chapter6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter6 - Command");
            Console.WriteLine();

            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            RemoteControl rc = new RemoteControl();
            Console.WriteLine(rc.ToString());

            Light lightInBedroom = new Light();
            LightOnCommand lightInBedroom_OnCommand = new LightOnCommand(lightInBedroom);
            LightOffCommand lightInBedroom_OffCommand = new LightOffCommand(lightInBedroom);
            Stereo myStereo = new Stereo();
            StereoOnWithCDCommand myStereo_On = new StereoOnWithCDCommand(myStereo);
            StereoOffWithCDCommand myStereo_Off = new StereoOffWithCDCommand(myStereo);
            CeilingFan fan = new CeilingFan("Living room");
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(fan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(fan);

            MacroCommand macroCommand_On = new MacroCommand(new ICommand[] { lightInBedroom_OnCommand, myStereo_On, ceilingFanHighCommand });
            MacroCommand macroCommand_Off = new MacroCommand(new ICommand[] { lightInBedroom_OffCommand, myStereo_Off, ceilingFanOffCommand });

            rc.SetCommand(0, lightInBedroom_OnCommand, lightInBedroom_OffCommand);
            rc.SetCommand(1, myStereo_On, myStereo_Off);
            rc.SetCommand(2, ceilingFanHighCommand, ceilingFanOffCommand);
            rc.SetCommand(6, macroCommand_On, macroCommand_Off);

            Console.WriteLine(rc.ToString());

            rc.OnButtonWasPressed(0);
            rc.OnButtonWasPressed(1);
            rc.OffButtonWasPressed(0);
            rc.UndoButtonWasPressed();
            rc.OnButtonWasPressed(2);
            rc.UndoButtonWasPressed();

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Call macro command");
            rc.OnButtonWasPressed(6);
            rc.OffButtonWasPressed(6);
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Macro command finished");
            Console.WriteLine();

            Console.WriteLine(rc.ToString());

            Console.ReadKey();
        }
    }
}
