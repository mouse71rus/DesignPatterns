using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Good.Products
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory PizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.PizzaIngredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = PizzaIngredientFactory.CreateDough();
            Sauce = PizzaIngredientFactory.CreateSauce();
            Cheese = PizzaIngredientFactory.CreateCheese();
        }
    }
}
