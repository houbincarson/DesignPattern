using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //责任链模式
            //1、抽象执行者==>具体执行者（责任划分）
            //2、消息模型 ==>处理消息
            AbstractExecutor employee = new Employee();
            AbstractExecutor leader = new Leader();
            AbstractExecutor manager = new Manager();
            //设置责任链
            employee.SetUpSuccessor(leader);
            leader.SetUpSuccessor(manager);

            Console.WriteLine(employee.Insert(new MessageModel("abcd", DateTime.Now)));
            Console.WriteLine(employee.Insert(new MessageModel("abcdefgh", DateTime.Now)));
            Console.WriteLine(employee.Insert(new MessageModel("abcdefghigkl", DateTime.Now)));
            Console.WriteLine(employee.Insert(new MessageModel("abcdefghigklmnop", DateTime.Now)));
            Console.ReadKey();
        }
    }
}
