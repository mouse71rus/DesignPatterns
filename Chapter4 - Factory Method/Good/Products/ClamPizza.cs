using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Good.Products
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory PizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.PizzaIngredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = PizzaIngredientFactory.CreateDough();
            Sauce = PizzaIngredientFactory.CreateSauce();
            Cheese = PizzaIngredientFactory.CreateCheese();
            Clams = PizzaIngredientFactory.CreateClam();
        }
    }
}
