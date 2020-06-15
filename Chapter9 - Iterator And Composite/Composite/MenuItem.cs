using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Composite
{
    public class MenuItem : MenuComponent
    {
        private string Name;
        private string Description;
        private bool Vegetarian;
        private double Price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }
        public override double GetPrice()
        {
            return Price;
        }
        public override bool IsVegetarian()
        {
            return Vegetarian;
        }

        public override void Print()
        {
            Console.Write(Name);
            if(Vegetarian)
            {
                Console.Write(" (v)");
            }
            Console.Write("\n");

            Console.WriteLine("\t\t" + Price);
            Console.WriteLine("\t" + Description);
        }
    }
}
