﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter4.Good.Ingredients;
using Chapter4.Good.Ingredients.Concrete;

namespace Chapter4.Good.NY
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
