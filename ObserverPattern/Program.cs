using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TenXun tenxun = new TenXunGame("TenXun Game", "Have a new game published......");
            tenxun.AddObserver(new Subscriber("Learning Hard"));
            tenxun.AddObserver(new Subscriber("Tom"));
            tenxun.Update();
            Console.ReadLine();


            ConcreteSubject consubject = new ConcreteSubject();
            consubject.Attach(new ConcreteObserver("X", consubject));
            consubject.Attach(new ConcreteObserver("Y", consubject));
            consubject.Attach(new ConcreteObserver("Z", consubject));
            consubject.SubjectState = "ABC";
            consubject.Notify();
            Console.ReadKey();
        }
    }
}
