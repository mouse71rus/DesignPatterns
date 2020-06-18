using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter12.MVC
{
    public partial class ViewForm : Form
    {
        private IBeatModelInterface model;

        public ViewForm(IBeatModelInterface beatModel)
        {
            InitializeComponent();
            this.model = beatModel;
            this.model.BPMChange += UpdateBPM;
            UpdateBPM();

            
        }

        private void UpdateBPM()
        {
            int bpm = model.GetBPM();
            if(bpm == 0)
            {
                CurrentBPM.Text = "Offline";
            }
            else
            {
                if (bpm <= 100 && bpm > 0)
                {
                    BeatBar.Value = bpm;
                    CurrentBPM.Text = bpm.ToString();
                }
            }
        }
    }
}