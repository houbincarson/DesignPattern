using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerModel
{
    public class ProducerA
    {
        private void produceGoods()
        {
            string goodsName = "" + System.DateTime.Now.Millisecond;
            Goods good = new Goods(goodsName);
            Console.WriteLine("创建商品A："+ good.GoodsName);
            GoodsStore.GetInstance().GoodsList.Add(good);
        }

        public  void Run()
        {
            while (true)
            {
                int sleepTime = new Random().Next(1000);
                try
                {
                    Thread.Sleep(sleepTime);
                }
                catch (Exception)
                {
                    
                    throw;
                }
                this.produceGoods();
            }
        }
    }
}
