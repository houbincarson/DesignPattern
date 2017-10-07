using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            IThreeHole threehole = new PowerAdapter();
            threehole.Request();
            Console.ReadLine();

            Target target = new PowerAdapterObject();
            target.Request();
            Console.ReadLine();
        }
    }
}
