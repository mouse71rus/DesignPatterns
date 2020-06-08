using System;

namespace Chapter7.Facade
{
    public class Projector
    {
        internal void On()
        {
            Console.WriteLine("Top-O-Line Projector on");
        }

        internal void WideScreenMode()
        {
            Console.WriteLine("Top-O-Line Projector in widescreen mode (16x9 aspect ratio)");
        }

        internal void Off()
        {
            Console.WriteLine("Top-O-Line Projector off");
        }
    }
}