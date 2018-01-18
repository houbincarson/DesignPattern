using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AgentAbstract fan = new AgentPerson();
            fan.Speculation("偶尔出来现现身，为炒作造势");
            Console.WriteLine();
            fan.Speculation("这段时间不火了，开始离婚炒作");
            Console.Read();
        }
    }
}
