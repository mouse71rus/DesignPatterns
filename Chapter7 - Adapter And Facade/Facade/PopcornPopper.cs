using System;

namespace Chapter7.Facade
{
    public class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popcorn Popper on");
        }

        internal void Pop()
        {
            Console.WriteLine("Popcorn Popper poping popcorn!");
        }

        internal void Off()
        {
            Console.WriteLine("Popcorn Popper off");
        }
    }
}