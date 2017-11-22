using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder myword = new Word();
            myword.Open();//打开文件，处理文件
            try
            {
                myword.Add(new SonFolder());//抛出异常
                myword.Remove(new SonFolder());//抛出异常
            }
            catch (Exception)
            {
                //
            }
            

            Folder myfolder=new SonFolder();
            myfolder.Open();//打开文件夹

            myfolder.Add(new SonFolder());//成功增加文件或者文件夹
            myfolder.Remove(new SonFolder());//成功删除文件或者文件夹



            SafeFolder safeFolder = new SafeWord();
            safeFolder.Open();

            SafeFolder mySafeFolder = new NextSafeFolder();
            mySafeFolder.Open();

            //此处要是用增加和删除功能，需要转型的操作，否则不能使用
            ((SonSafeFolder)(mySafeFolder)).Add(new NextSafeFolder());
            ((SonSafeFolder)(mySafeFolder)).Remove(new NextSafeFolder());


            Console.ReadKey();
        }
    }
}
