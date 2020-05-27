using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Bad
{
    public class DecoyDuck : Duck
    {
        public new void quack()
        {
            //Пустое переопределение, чтобы приманки не крякали
        }

        public new void fly()
        {
            //Пустое переопределение, чтобы приманки не летали
        }

        public override void display()
        {
            // Конкретная версия для DecoyDuck
        }
    }
}
