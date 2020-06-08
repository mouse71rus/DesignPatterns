using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan fan;
        private CeilingFan.Speed prevSpeed;

        public CeilingFanHighCommand(CeilingFan fan)
        {
            this.fan = fan;
            prevSpeed = this.fan.GetSpeed();
        }

        public void Execute()
        {
            fan.High();
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
