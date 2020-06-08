using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7.Facade
{
    public class HomeTheaterFacade
    {
        protected Amplifier amp;
        protected Tuner tuner;
        protected DvdPlayer dvd;
        protected CdPlayer cd;
        protected Projector projector;
        protected TheaterLights lights;
        protected Screen screen;
        protected PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, CdPlayer cd, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.lights = lights;
            this.screen = screen;
            this.popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie..");
            popper.On();
            popper.Pop();
            lights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amp.On();
            amp.SetDvd(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movew theater down..");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }
    }
}
