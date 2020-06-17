using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.Decorator
{
    public class QuackCounter : IQuackable
    {
        private static int numberOfQuacks = 0;
        private IQuackable duck;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }

        public static int GetCount()
        {
            return numberOfQuacks;
        }
    }
}