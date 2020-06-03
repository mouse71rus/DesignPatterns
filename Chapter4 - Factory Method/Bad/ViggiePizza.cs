using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Bad
{
    public class ViggiePizza : IPizza
    {
        public void bake()
        {
            Console.WriteLine("baking..");
        }

        public void box()
        {
            Console.WriteLine("boxing..");
        }

        public void cut()
        {
            Console.WriteLine("cuting..");
        }

        public void prepare()
        {
            Console.WriteLine("preparing..");
        }
    }
}