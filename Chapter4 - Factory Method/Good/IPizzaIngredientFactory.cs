using Chapter4.Good.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Good
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }
}
