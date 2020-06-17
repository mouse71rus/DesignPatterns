using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.Observer
{
    public interface IQuackObservable
    {
        void registerObserver(IObserver observer);
        void notifyObservers();
    }
}