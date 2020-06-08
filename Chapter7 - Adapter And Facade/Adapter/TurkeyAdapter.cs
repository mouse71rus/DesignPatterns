using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }

        public void Quack()
        {
            turkey.gobble();
        }
    }
}
