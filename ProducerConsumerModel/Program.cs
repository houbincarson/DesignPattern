using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread producerA = new Thread(new ProducerA().Run);
            producerA.Start();

            Thread consumerA = new Thread(new ConsumerA().Run);
            consumerA.Start();

            if (Console.ReadLine()=="A")
            {
                producerA.Abort();
            }
            

        }
    }
}
