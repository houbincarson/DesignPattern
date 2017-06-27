using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }
        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }
        public abstract MonkeyKingPrototype Clone();
    }

    public class ConcretePrototype : MonkeyKingPrototype
    {
        public ConcretePrototype(string id) : base(id)
        {
            
        }
        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }
    }

}
