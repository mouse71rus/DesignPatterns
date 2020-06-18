using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.MVC
{
    public interface IController
    {
        void Start();
        void Stop();
        void IncreaseBPM();
        void DecreaseBPM();
        void SetBPM(int bpm);
    }
}