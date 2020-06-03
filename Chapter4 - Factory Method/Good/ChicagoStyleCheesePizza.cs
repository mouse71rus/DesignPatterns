using System;

namespace Chapter4.Good
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago: Cheese";
            Dough = "Extra Thick Crust dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cuttin the pizza into square slices");
        }
    }
}