using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 下面是利用.NET Framework平台优势实现Singleton模式的代码：
    /// </summary>
    sealed class Singleton
    {
        private Singleton(){} 
        public static readonly Singleton Instance = new Singleton();
    }
}
