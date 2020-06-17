using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.Observer
{
    public class Observable : IQuackObservable
    {
        private List<IObserver> observers;
        private IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
            observers = new List<IObserver>();
        }

        public void notifyObservers()
        {
            var iterator = observers.GetEnumerator();
            while(iterator.MoveNext())
            {
                IObserver observer = iterator.Current;
                observer.Update(duck);
            }
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}