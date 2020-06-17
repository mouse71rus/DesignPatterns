using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.AbstractFactory
{
    public class DuckFactory : AbstractFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }

        public override IQuackable CreateGoose()
        {
            return new Adapter.GooseAdapter(new Adapter.Goose());
        }
    }
}