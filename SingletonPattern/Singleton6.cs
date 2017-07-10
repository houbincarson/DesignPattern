using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton6
    {
        private static readonly Singleton6 _Singleton6 = new Singleton6();

        static Singleton6()
        {
            
        }
        Singleton6()
        { }

        public static Singleton6 GetInstance
        {
            get
            {
                return _Singleton6;
            }
        }
    }
}
