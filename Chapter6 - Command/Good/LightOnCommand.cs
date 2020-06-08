using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}
