using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{

    /*
     * 优点：
     * 模板方法模式通过把不变的行为搬移到超类中，去除了子类中重复的代码
     * 子类实现算法的某些细节，有助于算法的扩展；
     * 通过一个父类调用子类实现操作，通过子类扩展添加新的行为，符合“开放-闭合”原则
     * 缺点：
     * 每个不同的实现都需要定义一个子类，这会导致类的个数的增加，设计更加抽象
     * 适用场景：
     * 在某些类的算法中，使用相同的方法，造成代码的重复；
     * 控制子类扩展，子类必须遵守算法规则
     */
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass a = new ConcreteClassA();
            a.TemplateMethod();

            a = new ConcreteClassB();
            a.TemplateMethod();




            int[] intArray = new int[] { 5, 3, 12, 8, 10 };

            IntBubbleSorter intBubbleSorter = new IntBubbleSorter();
            intBubbleSorter.Sort(intArray);
            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            float[] floatArray = new float[] { 5.1f, 3.1f, 12.1f, 8.1f, 10.1f };
            FloatBubbleSorter floatSorter = new FloatBubbleSorter();
            floatSorter.Sort(floatArray);
            foreach (float item in floatArray)
            {
                Console.Write(item + " ");
            }
            Console.Read();




        }
    }
}
