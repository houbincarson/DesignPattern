using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemFacade facade = new SystemFacade();
            facade.Buy();
            Console.Read();
        }
    }
}
