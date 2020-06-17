using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter12.Observer;

namespace Chapter12
{
    public class MallardDuck : IQuackable
    {
        private Observable observable;

        public MallardDuck()
        {
            observable = new Observable(this);
        }

        public void notifyObservers()
        {
            observable.notifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }

        public void registerObserver(IObserver observer)
        {
            observable.registerObserver(observer);
        }
    }
}