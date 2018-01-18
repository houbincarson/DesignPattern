using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            House myselfHouse = new PatrickLiuHouse();
            DecoratorStrategy securityHouse = new HouseSecurityDecorator(myselfHouse);
            securityHouse.Renovation();

            DecoratorStrategy securityAndWarmHouse = new KeepWarmDecorator(myselfHouse);
            securityAndWarmHouse.Renovation();

            Console.ReadKey();
        }
    }
}
