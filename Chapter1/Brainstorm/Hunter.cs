using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Brainstorm
{
    public abstract class Hunter
    {
        public IThing thing;

        public void PerformUseThing()
        {
            thing.Use();
        }
        
        /// <summary>
        /// SetThing method
        /// </summary>
        /// <param name="thing">Your thing</param>
        public void TakeThing(IThing thing)
        {
            this.thing = thing;
        }

        public abstract void display();
    }
}
