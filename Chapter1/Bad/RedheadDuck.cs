using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Bad
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override void display()
        {
            // Конкретная версия для RedheadDuck
        }

        public void Fly()
        {
            // Реализация полёта для RedheadDuck
        }

        public void Quack()
        {
            // Реализация кряконья для RedheadDuck
        }
    }
}
