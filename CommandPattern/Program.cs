using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //1、命令行模式的根本目的在于将“行为的请求者”和“行为的实现者”解耦；实现手段：“将行为抽象为对象”

            Document doc = new Document();
            DocumentCommand discmd = new DisplayCommand(doc);
            DocumentCommand undcmd = new UndoCommand(doc);
            DocumentCommand redcmd = new RedoCommand(doc);

            DocumentInvoker invoker = new DocumentInvoker(discmd, undcmd, redcmd);
            invoker.Display();
            invoker.Undo();
            invoker.Redo();



            PatrickLiuAndWife liuAndLai = new PatrickLiuAndWife();//命令接受者
            Command command = new MakeDumplingsCommand(liuAndLai);//命令
            PaPaInvoker papa = new PaPaInvoker(command); //命令请求者
            papa.ExecuteCommand();
            Console.ReadKey();
        }

        


    }
}
