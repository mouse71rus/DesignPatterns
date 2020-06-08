using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan fan;
        private CeilingFan.Speed prevSpeed;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            this.fan = fan;
            prevSpeed = this.fan.GetSpeed();
        }

        public void Execute()
        {
            fan.Off();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case CeilingFan.Speed.HIGH:
                    fan.High();
                    break;
                case CeilingFan.Speed.MEDIUM:
                    fan.Medium();
                    break;
                case CeilingFan.Speed.LOW:
                    fan.Low();
                    break;
                case CeilingFan.Speed.OFF:
                    fan.Off();
                    break;
            }
        }
    }
}
