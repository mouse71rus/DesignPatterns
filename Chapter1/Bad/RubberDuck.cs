using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Bad
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void display()
        {
            // Конкретная версия для RubberDuck
        }

        public void Quack()
        {
            // Реализация кряконья для RubberDuck
        }
    }
}
