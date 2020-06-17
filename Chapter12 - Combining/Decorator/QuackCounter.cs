using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter12.Observer;

namespace Chapter12.Decorator
{
    public class QuackCounter : IQuackable
    {
        private static int numberOfQuacks = 0;
        private IQuackable duck;
        private List<IObserver> observers = new List<IObserver>();
        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
            notifyObservers();
        }

        public static int GetCount()
        {
            return numberOfQuacks;
        }

        public void registerObserver(IObserver observer)
        {
            duck.registerObserver(observer);
        }

        public void notifyObservers()
        {
            duck.notifyObservers();
        }
    }
}