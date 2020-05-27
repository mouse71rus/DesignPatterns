using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Bad
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void display()
        {
            // Конкретная версия для MallardDuck
        }
        public void Fly()
        {
            // Реализация полёта для MallardDuck
        }

        public void Quack()
        {
            // Реализация кряконья для MallardDuck
        }
    }
}
