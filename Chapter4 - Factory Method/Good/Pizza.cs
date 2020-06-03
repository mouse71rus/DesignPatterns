using Chapter4.Good.Ingredients;
using System;
using System.Collections.Generic;

namespace Chapter4.Good
{
    public abstract class Pizza
    {
        protected string Name;
        protected IDough Dough;
        protected ISauce Sauce;
        protected IVeggies[] Veggies;
        protected ICheese Cheese;
        protected IPepperoni Pepperoni;
        protected IClams Clams;
        

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public abstract void prepare();

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}