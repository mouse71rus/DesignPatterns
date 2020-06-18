using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.MVC
{
    public interface IBeatModelInterface
    {
        //void Init();
        void On();
        void Off();

        void SetBPM(int bpm);
        int GetBPM();
        
        event BPMDelegate BPMChange;
        event BPMDelegate BeatChange;
    }
}