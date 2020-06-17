using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12.Adapter
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            goose.Honk();
        }
    }
}
