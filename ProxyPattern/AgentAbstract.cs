using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    public abstract class AgentAbstract
    {
        public virtual void Speculation(string thing)
        {
            Console.WriteLine(thing);
        }
    }

    public sealed class FanStar : AgentAbstract
    {
        public FanStar() { }

        public override void Speculation(string thing)
        {
            Console.WriteLine(thing);
        }
    }

    public sealed class AgentPerson : AgentAbstract
    {
        private FanStar boss;

        public AgentPerson()
        {
            boss = new FanStar();
        }

        public override void Speculation(string thing)
        {
            Console.WriteLine("前期弄点绯闻，拍点野照");
            base.Speculation(thing);
            Console.WriteLine("然后开发布会，伤心哭泣，继续捞钱");
        }
    }
}
