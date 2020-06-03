using System;

namespace Chapter4.Good
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY: Cheese";
            Dough = "Thin Crust dough";
            Sauce = "Marinara sauce";

            Toppings.Add("Grated reggiano Cheese");
        }
    }
}