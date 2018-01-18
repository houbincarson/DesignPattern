using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class House
    {
        public abstract void Renovation();
    }

    public abstract class DecoratorStrategy : House
    {
        protected House _house;

        protected DecoratorStrategy(House house)
        {
            this._house = house;
        }

        public override void Renovation()
        {
            if (_house != null)
            {
                _house.Renovation();
            }
        }
    }

    public sealed class PatrickLiuHouse : House
    {
        public override void Renovation()
        {
            Console.WriteLine("装修PatrickLiu的房子");
        }

    }

    public sealed class HouseSecurityDecorator : DecoratorStrategy
    {
        public HouseSecurityDecorator(House house) : base(house)
        {
        }

        public override void Renovation()
        {
            base.Renovation();
            Console.WriteLine("增加安全系统");
        }
    }

    public sealed class KeepWarmDecorator : DecoratorStrategy
    {
        public KeepWarmDecorator(House house) : base(house)
        {
        }

        public override void Renovation()
        {
            base.Renovation();
            Console.WriteLine("增加保温的功能");
        }
    }
}
