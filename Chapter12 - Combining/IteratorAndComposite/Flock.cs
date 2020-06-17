using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter12.Observer;

namespace Chapter12.IteratorAndComposite
{
    public class Flock : IQuackable
    {
        private List<IQuackable> quackers;

        public Flock()
        {
            quackers = new List<IQuackable>();
        }

        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }

        public void notifyObservers() { }

        public void Quack()
        {
            var iterator = quackers.GetEnumerator();
            while(iterator.MoveNext())
            {
                IQuackable quacker = iterator.Current;
                quacker.Quack();
            }
        }

        public void registerObserver(IObserver observer)
        {
            var iterator = quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quacker = iterator.Current;
                quacker.registerObserver(observer);
            }
        }
    }
}