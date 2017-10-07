using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("this is a common request");
        }
    }

    public class Adaptee
    {
        public void SpecialRequest()
        {
            Console.WriteLine("this is a specail request");
        }
    }

    public class PowerAdapterObject : Target
    {
        private readonly Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecialRequest();
        }
    }
}
