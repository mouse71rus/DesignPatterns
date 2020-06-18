using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.MVC
{
    public delegate void BPMDelegate();
    public class BeatModel : IBeatModelInterface
    {        
        public event BPMDelegate BPMChange;
        public event BPMDelegate BeatChange;

        private int BPM;

        public BeatModel()
        {

        }

        public int GetBPM()
        {
            return BPM;
        }

        public void Off()
        {
            SetBPM(0);
        }

        public void On()
        {
            SetBPM(90);
        }

        public void SetBPM(int bpm)
        {
            this.BPM = bpm;
            BPMChange?.Invoke();
        }
    }
}