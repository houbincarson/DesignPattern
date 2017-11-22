using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;

        public ConcreteObserver(string name, ConcreteSubject conSubject)
        {
            this._name = name;
            this.ConSubject = conSubject;
        }

        public ConcreteSubject ConSubject { get; set; }

        public override void Update()
        {
            _observerState = ConSubject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}",_name,_observerState);
        }
    }

    public abstract class Subject
    {
        private readonly IList<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }

}
