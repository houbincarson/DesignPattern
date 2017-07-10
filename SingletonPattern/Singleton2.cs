using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton2
    {
        /// <summary>
        /// 懒汉模式，线程安全
        /// volatile 关键字指示一个字段可以由多个同时执行的线程修改。 声明为 volatile 的字段不受编译器优化（假定由单个线程访问）的限制。 这样可以确保该字段在任何时间呈现的都是最新的值
        /// volatile 修饰符通常用于由多个线程访问但不使用 lock 语句对访问进行序列化的字段。
        /// </summary>
        private static volatile Singleton2 _singleton2 = null;
        private static readonly object LockHelper = new object();
        public Singleton2()
        {
        }

        public static Singleton2 GetSingleton2()
        {
            if (_singleton2==null)
            {
                lock (LockHelper)
                {
                    if (_singleton2 == null)
                    {
                        _singleton2 = new Singleton2();
                    }
                }
            }
            return _singleton2; 
        }
    }
}
