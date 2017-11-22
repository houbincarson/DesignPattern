using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    //安全式的组合模式的实现 

    //该抽象类就是文件夹抽象接口的定义，该类型就相当于是抽象构件Component类型
    //该类型少了容器对象管理子对象的方法的定义，换了地方，在树枝构件也就是SonSafeFolder类型
    public abstract class SafeFolder
    {
        //打开文件或者文件夹--该操作相当于Component类型的Operation方法
        public abstract void Open();
    }

    //该SafeWord文档类就是叶子构件的定义，该类型就相当于是Leaf类型，不能在包含子对象
    public sealed class SafeWord : SafeFolder
    {
        public override void Open()
        {
            Console.WriteLine("打开Word文档，开始进行编辑");
        }
    }
    /// <summary>
    /// SonSafeFolder类型就是树枝构件，现在由于我们使用的是“安全式”，所以Add,Remove都是从此处开始定义的
    /// </summary>
    public abstract class SonSafeFolder : SafeFolder
    {
        //增加文件夹或文件
        public abstract void Add(SafeFolder folder);

        //删除文件夹或者文件
        public abstract void Remove(SafeFolder folder);

        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }
    }

    public sealed class NextSafeFolder : SonSafeFolder
    {
        public override void Add(SafeFolder folder)
        {
            Console.WriteLine("文件或者文件夹已经增加成功");
        }

        public override void Remove(SafeFolder folder)
        {
            Console.WriteLine("文件或者文件夹已经删除成功");
        }

        //打开文件夹--该操作相当于Component类型的Operation方法
        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }
    }



}
