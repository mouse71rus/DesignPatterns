using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Bad
{
    public class PizzaStore
    {
        private SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public IPizza order(string type)
        {
            IPizza pizza = factory.CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
