using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VistorPattern
{
    /// <summary>
    /// 抽象元素角色
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(IVistor vistor);
        public abstract void Print();
    }
    public class ElementA : Element
    {
        public override void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素A");
        }
    }
    public class ElementB : Element
    {
        public override void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素B");
        }
    }

    /// <summary>
    /// 抽象访问者
    /// </summary>
    public interface  IVistor
    {
        void Visit(Element a);
    }
    /// <summary>
    /// 具体访问者
    /// </summary>
    public class ConcreteVistor : IVistor
    {
        public void Visit(Element a)
        {
           a.Print();
        }
    }

    /// <summary>
    /// 对象结构
    /// </summary>
    public class ObjectStructure
    {
        private ArrayList elements = new ArrayList();

        public ArrayList Elements
        {
            get { return elements; }
        }

        public ObjectStructure()
        {
            Random ran = new Random();
            for (int i = 0; i < 11; i++)
            {
                int ranNum = ran.Next(10);
                if (ranNum > 5)
                {
                    elements.Add(new ElementA());
                }
                else
                {
                    elements.Add(new ElementB());
                }
            }
        }
    }
}
