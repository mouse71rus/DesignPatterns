using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chapter12.MVC
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            IBeatModelInterface beatModel = new BeatModel();
            IController controller = new BeatController(beatModel);
        }
    }
}
