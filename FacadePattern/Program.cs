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
//在外观模式中，当增加或移除子系统时需要修改外观类，这违背了“开闭原则”。如果引入抽象外观类，则在一定程度上解决了该问题
//抽象外观
public abstract class AbstractFacade
{
    public void Method1();
    public void Method2();
}
//子系统1
public class SubSystem1
{
    public void method1()
    {
        Console.WriteLine("子系统1-方法1");
    }
}
public class SubSystem2
{
    public void method2()
    {
        Console.WriteLine("子系统2-方法2");
    }
}
public class SubSystem3
{
    public void method3()
    {
        Console.WriteLine("子系统3-方法3");
    }
}
public class SubSystem4
{
    public void method4()
    {
        Console.WriteLine("子系统4-方法4");
    }
}
//具体外观1
public class SubFacade1:AbstractFacade
{
    private SubSystem1 obj1;
    private SubSystem2 obj2;
    private SubSystem3 obj3; 
    
    public SubFacade1()
    {
        obj1 = new SubSystem1();
        obj2 = new SubSystem2();
        obj3 = new SubSystem3();
    }
    public override void Method1()
    {
       obj1.method1();
       obj2.method1();
       obj3.method1();
    }
    
     public override void Method2()
    {
       obj2.method2();
       obj3.method3();
    }
}

public class SubFacade2:AbstractFacade
{
    private SubSystem4 obj4;
    private SubSystem2 obj2;
    private SubSystem3 obj3; 
    
    public SubFacade1()
    {
        obj4 = new SubSystem4();
        obj2 = new SubSystem2();
        obj3 = new SubSystem3();
    }
    public override void Method1()
    {
       obj4.method4();
       obj2.method2();
       obj3.method3();
    }
    
    public override void Method2()
    {
       obj2.method2();
       obj3.method3();
    }
}
