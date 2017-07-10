using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton5
    {
        private Singleton5()
        {

        }

        public static Singleton5 GetSingleton5()
        {
            return Nested.Instance;
        }

        class Nested
        {
            static Nested()
            {

            }

            internal static readonly Singleton5 Instance = new Singleton5(); 
        }

       
    }
}
