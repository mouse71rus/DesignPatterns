using Chapter4.Good.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Good.NY
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("NY Style Cheese Pizza");
                    break;
                case "Clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("NY Style Clam Pizza");
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
