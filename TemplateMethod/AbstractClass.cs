using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("Done the method.");
        }
    }

    public class ConcreteClassA : AbstractClass
    {

        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Implement operation 1 in Concreate class A.");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Implement operation 2 in Concreate class A.");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Implement operation 1 in Concreate class B.");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Implement operation 2 in Concreate class B.");
        }
    }
}
