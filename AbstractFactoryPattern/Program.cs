using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = ProducterFactory.GetFactory("Shape");

            IShape shape1 = shapeFactory.GetShape("Shape1");
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("Shape2");
            shape2.Draw();

            IShape shape3 = shapeFactory.GetShape("Shape3");
            shape3.Draw();

            AbstractFactory colorFactory = ProducterFactory.GetFactory("Color");

            IColor color1 = colorFactory.GetColor("Color1");
            color1.Fill();

            IColor color2 = colorFactory.GetColor("Color2");
            color2.Fill();

            IColor color3 = colorFactory.GetColor("Color3");
            color3.Fill();

            Console.ReadKey();
        }
    }

    public interface IShape
    {
        void Draw();
    }

    public interface IColor
    {
        void Fill();
    }

    public class Shape1 : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape1");
        }
    }
    public class Shape2 : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape2");
        }
    }
    public class Shape3 : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape3");
        }
    }

    public class Color1 : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Color1");
        }
    }
    public class Color2 : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Color2");
        }
    }
    public class Color3 : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Color3");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
        public abstract IColor GetColor(string color);
    }

    public class ShapeFactory : AbstractFactory
    {

        public override IShape GetShape(string shape)
        {
            if (string.IsNullOrEmpty(shape))
            {
                return null;
            }
            if ("Shape1".Equals(shape))
            {
                return new Shape1();
            }
            if ("Shape2".Equals(shape))
            {
                return new Shape2();
            }
            if ("Shape3".Equals(shape))
            {
                return new Shape3();
            }
            return null;
        }

        public override IColor GetColor(string color)
        {
            return null;
        }
    }

    public class ColorFactory : AbstractFactory
    {

        public override IShape GetShape(string shape)
        {
            return null;
        }

        public override IColor GetColor(string color)
        {
            if (string.IsNullOrEmpty(color))
            {
                return null;
            }
            if ("Color1".Equals(color))
            {
                return new Color1();
            }
            if ("Color2".Equals(color))
            {
                return new Color2();
            }
            if ("Color3".Equals(color))
            {
                return new Color3();
            }
            return null;
        }
    }

    public class ProducterFactory
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if ("Shape".Equals(choice))
            {
                return  new ShapeFactory();
            }
            else
            {
                return new ColorFactory();
            }
        }
    }
}
