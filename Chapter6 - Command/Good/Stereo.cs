namespace Chapter6.Good
{
    public class Stereo
    {
        public void On()
        {
            System.Console.WriteLine("Stereo is On");
        }

        public void Off()
        {
            System.Console.WriteLine("Stereo is Off");
        }

        public void SetCD()
        {
            System.Console.WriteLine("Stereo is set for CD input");
        }

        public void SetVolume(int volume)
        {
            System.Console.WriteLine($"Stereo volume set to {volume}");
        }
    }
}