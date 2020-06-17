using Chapter12.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }

        private Observable observable;

        public DuckCall()
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