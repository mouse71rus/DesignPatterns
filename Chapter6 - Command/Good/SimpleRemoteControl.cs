using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public class SimpleRemoteControl
    {
        private ICommand slot;

        public void SetCommand(ICommand command)
        {
            slot = command;
        }


        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
