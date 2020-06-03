using System;

namespace Chapter4.Good
{
    public class ChicagoStyleViggiePizza : Pizza
    {
        public ChicagoStyleViggiePizza()
        {
            Name = "Chicago: Viggie";
            Dough = "Extra Thick Crust dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Viggie");
        }

        public override void cut()
        {
            Console.WriteLine("Cuttin the pizza into square slices");
        }
    }
}