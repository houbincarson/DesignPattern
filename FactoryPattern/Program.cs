using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;

namespace FactoryPattern
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PrintTemplateFactory();
            var temp136 = factory.GetPrintTemplate("136");
            temp136.Print();
            var temp200 = factory.GetPrintTemplate("200");
            temp200.Print();
            var temp210 = factory.GetPrintTemplate("210");
            temp210.Print();
        }
    }

    public class LogisticsYdPrintModel
    {
    }
    public class TagPrintModel
    {
    }
     //应该是一个工厂模式，创建了136、200、210等等模板；
    public interface IPrintTemplate
    {
        void Print();
    }

    public class PrintTemplate : IPrintTemplate
    {
        private readonly PrintDocument printDocument = new PrintDocument();

        public PrintTemplate(List<LogisticsYdPrintModel> printModelList)
        {
            
        }

        public PrintTemplate(TagPrintModel tagPrintModel) 
        {

        }

        public void Print()
        {
            printDocument.PrintPage += printDocument_PrintPage;
            printDocument.Print();
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            DrawLines(e);
            DrawStrings(e);
        }

        private void DrawStrings(PrintPageEventArgs e)
        {
            e.Graphics.DrawString("11111111",new Font("微软雅黑",8f),new SolidBrush(Color.Black),1f,1f);
            e.Graphics.DrawString("22222222", new Font("微软雅黑", 8f), new SolidBrush(Color.Black), 1f, 20f);
        }

        private void DrawLines(PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f,1f,99f,1f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 20f, 99f, 20f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 40f, 99f, 40f); 
        }
    }

    public class PrintTemplate136 : IPrintTemplate
    {
        private readonly PrintDocument printDocument = new PrintDocument();

        public PrintTemplate136(List<LogisticsYdPrintModel> printModelList)
        {

        }

        public PrintTemplate136(TagPrintModel tagPrintModel)
        {

        }

        public void Print()
        {
            printDocument.PrintPage += printDocument_PrintPage;
            printDocument.Print();
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            DrawLines(e);
            DrawStrings(e);
        }

        private void DrawStrings(PrintPageEventArgs e)
        {
            e.Graphics.DrawString("136", new Font("微软雅黑", 18f), new SolidBrush(Color.Black), 1f, 1f);
            e.Graphics.DrawString("136", new Font("微软雅黑", 18f), new SolidBrush(Color.Black), 1f, 20f);
        }

        private void DrawLines(PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 1f, 99f, 1f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 20f, 99f, 20f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 40f, 99f, 40f);
        }
    }

    public class PrintTemplate210 : IPrintTemplate
    {
        private readonly PrintDocument printDocument = new PrintDocument();

        public PrintTemplate210(List<LogisticsYdPrintModel> printModelList)
        {

        }

        public PrintTemplate210(TagPrintModel tagPrintModel)
        {

        }

        public void Print()
        {
            printDocument.PrintPage += printDocument_PrintPage;
            printDocument.Print();
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            DrawLines(e);
            DrawStrings(e);
        }

        private void DrawStrings(PrintPageEventArgs e)
        {
            e.Graphics.DrawString("210", new Font("微软雅黑", 18f), new SolidBrush(Color.Black), 1f, 1f);
            e.Graphics.DrawString("210", new Font("微软雅黑", 18f), new SolidBrush(Color.Black), 1f, 20f);
        }

        private void DrawLines(PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 1f, 99f, 1f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 20f, 99f, 20f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 40f, 99f, 40f);
        }
    }

    public class PrintTemplate200 : IPrintTemplate
    {
        private readonly PrintDocument printDocument = new PrintDocument();

        public PrintTemplate200(List<LogisticsYdPrintModel> printModelList)
        {

        }

        public PrintTemplate200(TagPrintModel tagPrintModel)
        {

        }

        public void Print()
        {
            printDocument.PrintPage += printDocument_PrintPage;
            printDocument.Print();
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            DrawLines(e);
            DrawStrings(e);
        }

        private void DrawStrings(PrintPageEventArgs e)
        {
            e.Graphics.DrawString("200", new Font("微软雅黑", 18f), new SolidBrush(Color.Black), 1f, 1f);
            e.Graphics.DrawString("200", new Font("微软雅黑", 18f), new SolidBrush(Color.Black), 1f, 20f);
        }

        private void DrawLines(PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 1f, 99f, 1f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 20f, 99f, 20f);
            e.Graphics.DrawLine(new Pen(Color.Black, 0.2f), 1f, 40f, 99f, 40f);
        }
    }

    public class PrintTemplateFactory
    {
        public IPrintTemplate GetPrintTemplate(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            if (name.Equals("136"))
            {
                return new PrintTemplate136(new List<LogisticsYdPrintModel>());
            }
            else if (name.Equals("210"))
            {
                return new PrintTemplate210(new List<LogisticsYdPrintModel>());
            }
            else
            {
                return new PrintTemplate200(new List<LogisticsYdPrintModel>());
            }
        }
    }
}
