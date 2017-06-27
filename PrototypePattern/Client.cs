using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            MonkeyKingPrototype prototypeMonkeyKing = new ConcretePrototype("MonkeyKing");

            // 变一个
            MonkeyKingPrototype cloneMonkeyKing = prototypeMonkeyKing.Clone() as ConcretePrototype;
            if (cloneMonkeyKing != null)
            {
                Console.WriteLine("Cloned1:\t" + cloneMonkeyKing.Id);
            }

            // 变两个
            MonkeyKingPrototype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as ConcretePrototype;
            if (cloneMonkeyKing2 != null)
            {
                Console.WriteLine("Cloned2:\t" + cloneMonkeyKing2.Id);
            }
            Console.ReadLine();
        }
    }
}
