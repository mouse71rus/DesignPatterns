using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.AbstractFactory
{
    public class CountingDuckFactory : AbstractFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new Decorator.QuackCounter(new DuckCall());
        }

        public override IQuackable CreateGoose()
        {
            return new Adapter.GooseAdapter(new Adapter.Goose());
        }

        public override IQuackable CreateMallardDuck()
        {
            return new Decorator.QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new Decorator.QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new Decorator.QuackCounter(new RubberDuck());
        }
    }
}
