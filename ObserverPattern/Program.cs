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

            Cat cat = new Cat();
            Mouse m = new Mouse();
            People p = new People();
            cat.Add(m);
            cat.Add(p);
            cat.Cryed();


            Console.ReadKey();
        }


        public abstract class AbsSubject
        {
            public List<IOb> List = new List<IOb>();

            public void Add(IOb ob)
            {
                List.Add(ob);
            }

            public  void Remove(IOb ob)
            {
                if (List.Contains(ob))
                {
                    List.Remove(ob);
                }   
            }
            public abstract void Cryed();
        }


        public class Cat : AbsSubject
        {
            public override void Cryed()
            {
                Console.WriteLine("Cryed....");
                foreach (IOb ob in List)
                {
                    if (ob!=null)
                    {
                        ob.DoSomething();
                    }
                }
            }
        }
        public interface IOb
        {
            void DoSomething();
        }
        public class Mouse : IOb
        {
            public Mouse()
            {
              
            }
            public void DoSomething()
            {
                Console.WriteLine("Run....");
            }
        }

        public class People : IOb
        {
            public People()
            {
                
            }
            public void DoSomething()
            {
                Console.WriteLine("Wake Up....");
            }
        }

    }
}
