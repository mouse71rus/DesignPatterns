using System;

namespace Chapter4.Good
{
    public class NYStyleViggiePizza : Pizza
    {
        public NYStyleViggiePizza()
        {
            Name = "NY: Viggie";
            Dough = "Thin Crust dough";
            Sauce = "Marinara sauce";

            Toppings.Add("Grated reggiano Viggie");
        }
    }
}