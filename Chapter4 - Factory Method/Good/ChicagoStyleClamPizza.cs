using System;

namespace Chapter4.Good
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago: Clam";
            Dough = "Extra Thick Crust dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Clam");
        }

        public override void cut()
        {
            Console.WriteLine("Cuttin the pizza into square slices");
        }
    }
}