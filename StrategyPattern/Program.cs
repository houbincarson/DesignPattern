using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //意图：定义一系列的算法,把它们一个个封装起来, 并且使它们可相互替换。
            //主要解决：在有多种算法相似的情况下，使用 if...else 所带来的复杂和难以维护。
            //何时使用：一个系统有许多许多类，而区分它们的只是他们直接的行为。
            //如何解决：将这些算法封装成一个一个的类，任意地替换。
            //使用场景： 1、如果在一个系统里面有许多类，它们之间的区别仅在于它们的行为，那么使用策略模式可以动态地让一个对象在许多行为中选择一种行为。 2、一个系统需要动态地在几种算法中选择一种。 3、如果一个对象有很多的行为，如果不用恰当的模式，这些行为就只好使用多重的条件选择语句来实现。
            //注意事项：如果一个系统的策略多于四个，就需要考虑使用混合模式，解决策略类膨胀的问题。
            var context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = {0}",context.ExecuteStrategy(10,5));

            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = {0}", context.ExecuteStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = {0}", context.ExecuteStrategy(10, 5));

            Console.ReadKey();
        }
    }
}
