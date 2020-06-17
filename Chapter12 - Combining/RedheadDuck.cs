using Chapter12.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        private Observable observable;

        public RedheadDuck()
        {
            observable = new Observable(this);
        }

        public void notifyObservers()
        {
            observable.notifyObservers();
        }

        public void registerObserver(IObserver observer)
        {
            observable.registerObserver(observer);
        }
    }
}