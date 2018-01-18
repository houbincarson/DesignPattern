using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            SoldierFactory factory = new SoldierFactory();
            AK47 ak47 = new AK47();
            for (int i = 0; i < 100; i++)
            {
                Soldier soldier = null;
                if (i <= 20)
                {
                    soldier = factory.GetSoldier("士兵" + (i + 1), ak47, SoldierType.Normal);
                }
                else
                {
                    soldier = factory.GetSoldier("士兵" + (i + 1), ak47, SoldierType.Water);
                }
                soldier.Fight();
            }
            Console.Read();
        }
    }
}
