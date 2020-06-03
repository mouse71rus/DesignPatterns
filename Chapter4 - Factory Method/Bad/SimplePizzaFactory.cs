using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Bad
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            IPizza pizza;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "Clam":
                    pizza = new ClamPizza();
                    break;
                case "Viggie":
                    pizza = new ViggiePizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
