using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Good
{
    public abstract class PizzaStore
    {
        public Pizza Order(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
