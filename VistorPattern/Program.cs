using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VistorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure objectStructure = new ObjectStructure();
            foreach (Element e in objectStructure.Elements)
            {
                e.Accept(new ConcreteVistor());
            }
            Console.ReadKey();
        }
    }
}
