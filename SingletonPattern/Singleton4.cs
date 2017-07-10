using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton4
    {
        private static Singleton4 _singleton4 = new Singleton4();
        private static readonly object LockHelper = new object();

        private Singleton4()
        {
            
        }

        public static Singleton4 GetSingleton4()
        {
            if (_singleton4==null)
            {
                lock (LockHelper)
                {
                    if (_singleton4 == null)
                    {
                        _singleton4 = new Singleton4();
                    }
                }
            }
            return _singleton4;
        }
       
    }
}
