using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter12.Observer;

namespace Chapter12.Adapter
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;
        private Observable observable;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observable = new Observable(this);
        }

        public void Quack()
        {
            goose.Honk();
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