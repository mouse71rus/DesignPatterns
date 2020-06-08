﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6.Good
{
    public class StereoOnWithCDCommand : ICommand
    {
        private Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
