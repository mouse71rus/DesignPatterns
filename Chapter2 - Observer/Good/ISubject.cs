using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Good
{
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
    }
}
