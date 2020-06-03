using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Good
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "Cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "Clam":
                    pizza = new NYStyleClamPizza();
                    break;
                case "Viggie":
                    pizza = new NYStyleViggiePizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
