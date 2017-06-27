using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class RemoteControl
    {
        public TV Implementor { get; set; }

        public virtual void On()
        {
            Implementor.On();
        }
        public virtual void Off()
        {
            Implementor.Off();
        }
        public virtual void SetChannel()
        {
            Implementor.TuneChannel();
        }
    }
    public class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("---------------------");
            base.SetChannel();
            Console.WriteLine("---------------------");
        }
    }
}
