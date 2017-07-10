using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉模式
    /// </summary>
    public class Singleton1
    {
        private static Singleton1 _instance;

        public Singleton1()
        {
            
        }

        public static Singleton1 GetInstance()
        {
            if (_instance==null)
            {
                _instance = new Singleton1();
            }
            return _instance;
        }
    }
}
