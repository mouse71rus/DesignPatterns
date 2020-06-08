using System;

namespace Chapter7.Facade
{
    public class Amplifier
    {
        internal void On()
        {
            Console.WriteLine("Top-O-Line Amplifier on");
        }

        internal void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine("Top-O-Line Amplifier setting DVD player to Top-O-Screen DVD Player");
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("Top-O-Line Amplifier setting surround sound on (5 speakers, 1 subwoofer)");
        }

        internal void SetVolume(int v)
        {
            Console.WriteLine($"Top-O-Line Amplifier setting volume to {v}");
        }

        internal void Off()
        {
            Console.WriteLine("Top-O-Line Amplifier off");
        }
    }
}