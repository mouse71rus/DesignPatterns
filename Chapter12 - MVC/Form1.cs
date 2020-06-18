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
    public partial class Form1 : Form
    {
        private IBeatModelInterface model;
        private IController controller;
        public Form1(IController controller, IBeatModelInterface beatModel, out Form1 form)
        {
            InitializeComponent();
            this.model = beatModel;
            this.controller = controller;
            form = this;
            Form view = new ViewForm(beatModel);
            view.Show();
            //this.model.
        }

        internal void EnableStartMenuItem()
        {
            startToolStripMenuItem.Enabled = true;
        }
        public void DisableStartMenuItem()
        {
            startToolStripMenuItem.Enabled = false;
        }

        public void EnableStopMenuItem()
        {
            stopToolStripMenuItem.Enabled = true;
        }

        internal void DisableStopMenuItem()
        {
            stopToolStripMenuItem.Enabled = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.Stop();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            int bpm;
            if(int.TryParse(InputBMP.Text, out bpm))
            {
                controller.SetBPM(bpm);
            }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            controller.DecreaseBPM();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            controller.IncreaseBPM();
        }
    }
}