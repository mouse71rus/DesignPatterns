using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public class RemoteControl
    {
        private ICommand[] commandsOn;
        private ICommand[] commandsOff;
        private ICommand undoCommand;
        private readonly int length = 7;

        public RemoteControl()
        {
            this.commandsOn = new ICommand[length];
            this.commandsOff = new ICommand[length];


            ICommand noCommand = new NoCommand();
            undoCommand = noCommand;
            for (int i = 0; i < length; i++)
            {
                commandsOn[i] = noCommand;
                commandsOff[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if (slot > length || slot < 0)
                return;

            commandsOn[slot] = onCommand;
            commandsOff[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            if (slot > length || slot < 0)
                return;

            commandsOn[slot].Execute();
            undoCommand = commandsOn[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            if (slot > length || slot < 0)
                return;
            
            commandsOff[slot].Execute();
            undoCommand = commandsOff[slot];
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----------Remote----------\n");
            for (int i = 0; i < length; i++)
            {
                sb.Append($"[slot {i}]\t{commandsOn[i].ToString()} \t{commandsOff[i].ToString()}\n");
            }
            sb.Append($"[undo]\t{undoCommand.ToString()}\n");
            return sb.ToString();
        }
    }
}
