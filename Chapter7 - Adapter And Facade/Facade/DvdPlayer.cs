using System;

namespace Chapter7.Facade
{
    public class DvdPlayer
    {
        internal void On()
        {
            Console.WriteLine("Top-O-Line DVD Player on");
        }

        internal void Play(string movie)
        {
            Console.WriteLine("Top-O-Line DVD Player playing \"Rober B.Weide\"");
        }

        internal void Stop()
        {
            Console.WriteLine("Top-O-Line DVD Player stopped \"Rober B.Weide\"");
        }

        internal void Eject()
        {
            Console.WriteLine("Top-O-Line DVD Player eject");
        }

        internal void Off()
        {
            Console.WriteLine("Top-O-Line DVD Player off");
        }
    }
}