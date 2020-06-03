using System;

namespace Chapter4.Good
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY: Clam";
            Dough = "Thin Crust dough";
            Sauce = "Marinara sauce";

            Toppings.Add("Grated reggiano Clam");
        }
    }
}