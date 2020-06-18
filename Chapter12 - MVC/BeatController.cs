using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter12.MVC
{
    public class BeatController : IController
    {
        private IBeatModelInterface model;
        private Form1 view;

        public BeatController(IBeatModelInterface model)
        {
            this.model = model;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(this, model, out view));
            //view = (Form1)Application.OpenForms[0];
        }

        public void DecreaseBPM()
        {
            int bpm = model.GetBPM();
            model.SetBPM(--bpm);
        }

        public void IncreaseBPM()
        {
            int bpm = model.GetBPM();
            model.SetBPM(++bpm);
        }

        public void SetBPM(int bpm)
        {
            model.SetBPM(bpm);
        }

        public void Start()
        {
            model.On();
            view.DisableStartMenuItem();
            view.EnableStopMenuItem();
        }

        public void Stop()
        {
            model.Off();
            view.DisableStopMenuItem();
            view.EnableStartMenuItem();
        }
    }
}
