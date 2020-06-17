using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.Observer
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck.ToString()} just quacked.");
        }
    }
}
