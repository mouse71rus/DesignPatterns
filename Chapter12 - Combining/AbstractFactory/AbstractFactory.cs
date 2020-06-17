using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();

        public abstract IQuackable CreateGoose();
    }
}
