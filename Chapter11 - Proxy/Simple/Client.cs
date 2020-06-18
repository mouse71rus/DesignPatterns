using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11.Simple
{
    public class Client
    {
        public void Main()
        {
            ISubject subject = new Proxy();
            subject.Request();
        }
    }
}
