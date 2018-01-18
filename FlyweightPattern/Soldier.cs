using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{

    public enum SoldierType
    {
        Normal,
        Water
    }
    public abstract class Soldier
    {
        public string Name { get; private set; }
        protected Soldier(string name)
        {
            this.Name = name;
        }
        public abstract void Fight();
        public Weapen WeapenInstance { get; set; }
    }

    public sealed class NormalSoldier : Soldier
    {
        public NormalSoldier(string name) : base(name)
        {
        }

        public override void Fight()
        {
            WeapenInstance.Fire("士兵：" + Name + " 在陆地执行击毙任务");
        }
    }

    public sealed class WaterSoldier : Soldier
    {
        public WaterSoldier(string name) : base(name)
        {
        }

        public override void Fight()
        {
            WeapenInstance.Fire("士兵：" + Name + " 在海中执行击毙任务");
        }
    }

    public sealed class SoldierFactory
    {
        private static IList<Soldier> soldiers;

        static SoldierFactory()
        {
            soldiers = new List<Soldier>();
        }
        Soldier mySoldier = null;

        public Soldier GetSoldier(string name, Weapen weapen, SoldierType soldierType)
        {
            foreach (Soldier soldier in soldiers)
            {
                if (string.Compare(soldier.Name, name, true) == 0)
                {
                    mySoldier = soldier;
                    return mySoldier;
                }
            }
            if (soldierType == SoldierType.Normal)
            {
                mySoldier = new NormalSoldier(name);
            }
            else
            {
                mySoldier = new WaterSoldier(name);
            }
            mySoldier.WeapenInstance = weapen;
            soldiers.Add(mySoldier);
            return mySoldier;
        }
    }

    public abstract class Weapen
    {
        public abstract void Fire(string jobName);
    }

    public sealed class AK47 : Weapen
    {
        public override void Fire(string jobName)
        {
            Console.WriteLine(jobName);
        }
    }
}
