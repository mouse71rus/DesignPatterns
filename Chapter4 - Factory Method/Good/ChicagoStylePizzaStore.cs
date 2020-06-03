using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Good
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "Cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "Clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case "Viggie":
                    pizza = new ChicagoStyleViggiePizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
