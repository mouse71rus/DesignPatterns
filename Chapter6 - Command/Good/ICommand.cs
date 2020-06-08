using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
