﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}