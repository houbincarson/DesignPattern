using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class Singleton3
    {
        private static Singleton3 _singleton3 = new Singleton3();
        private Singleton3()
        { }

        public static Singleton3 GetSingleton3()
        {
            return _singleton3;
        }
    }
}
