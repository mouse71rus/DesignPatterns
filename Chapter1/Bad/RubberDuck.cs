using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.Bad
{
    public class RubberDuck : Duck
    {
        public new void quack()
        {
            //Пустое переопрделение, чтобы резиновые утки не крякали
        }

        public override void display()
        {
            // Конкретная версия для RubberDuck
        }
    }
}
