using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Document
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Undo()
        {
            Console.WriteLine("Undo");
        }
        public void Redo()
        {
            Console.WriteLine("Redo");
        }
    }

    public abstract class DocumentCommand
    {
        public Document _document;
        protected DocumentCommand(Document doc)
        {
            this._document = doc;
        }

        public abstract void Execute();
    }

    public class DisplayCommand : DocumentCommand
    {
        public override void Execute()
        {
            _document.Display();   
        }

        public DisplayCommand(Document doc) : base(doc)
        {
        }
    }
    public class UndoCommand  : DocumentCommand
    {
        public override void Execute()
        {
            _document.Undo();  
        }

        public UndoCommand(Document doc)
            : base(doc)
        {
        }
    }
    public class RedoCommand : DocumentCommand
    {
        public override void Execute()
        {
            _document.Redo();   
        }

        public RedoCommand(Document doc)
            : base(doc)
        {
        }
    }

    public class DocumentInvoker
    {
        DocumentCommand _discmd;
        DocumentCommand _undcmd;
        DocumentCommand _redcmd;

        public DocumentInvoker(DocumentCommand discmd, DocumentCommand undcmd, DocumentCommand redcmd)
        {
            this._discmd = discmd;
            this._undcmd = undcmd;
            this._redcmd = redcmd;
        }

        public void Display()
        {
            _discmd.Execute();
        }

        public void Undo()
        {
            _undcmd.Execute();
        }
        public void Redo()
        {
            _redcmd.Execute();
        }
    }

}
