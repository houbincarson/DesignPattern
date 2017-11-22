using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// 透明式的组合模式
    /// </summary>
    /// 
    /// 该抽象类就是文件夹抽象接口的定义，该类型就相当于是[抽象构件]Component类型
    public abstract class Folder
    {
        //增加文件夹或文件
        public abstract void Add(Folder folder);
        //删除文件夹或者文件
        public abstract void Remove(Folder folder);

        //打开文件或者文件夹--该操作相当于Component类型的Operation方法
        public abstract void Open();

    }
    public sealed class Word : Folder
    {
        public override void Add(Folder folder)
        {
            throw new Exception("Word文档不具有该功能");
        }

        public override void Remove(Folder folder)
        {
            throw new Exception("Word文档不具有该功能");
        }

        public override void Open()
        {
            Console.WriteLine("打开Word文档，开始进行编辑");
        }
    }

    public class SonFolder : Folder
    {
        public override void Add(Folder folder)
        {
            Console.WriteLine("文件或者文件夹已经增加成功");
        }

        public override void Remove(Folder folder)
        {
            Console.WriteLine("文件或者文件夹已经删除成功");
        }

        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }
    }

}
