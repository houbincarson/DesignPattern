using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public sealed class PaPaInvoker
    {
        private Command _command;

        public PaPaInvoker(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.MakeDumplings();
        }
    }
    public abstract class Command
    {
        protected PatrickLiuAndWife _worker;

        protected Command(PatrickLiuAndWife worker)
        {
            _worker = worker;
        }
        public abstract void MakeDumplings();
    }

    public sealed class MakeDumplingsCommand : Command
    {
        public MakeDumplingsCommand(PatrickLiuAndWife worker) : base(worker) { }

        public override void MakeDumplings()
        {
            _worker.Execute("今天包的是农家猪肉和农家大葱馅的饺子");
        }
    }

    public sealed class PatrickLiuAndWife
    {
        public void Execute(string job)
        {
            Console.WriteLine(job);
        }
    }
}
