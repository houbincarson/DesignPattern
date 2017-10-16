using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerModel
{
    public class ConsumerA
    {
        private void ConsumerGoods()
        {
            var good = GoodsStore.GetInstance().GoodsList.First();
            Console.WriteLine("消费商品A：" + good.GoodsName);
            GoodsStore.GetInstance().GoodsList.Remove(good);
        }

        public void Run()
        {
            while (true)
            {
                int sleepTime = new Random().Next(1200);
                try
                {
                    Thread.Sleep(sleepTime);
                }
                catch (Exception e)
                {
                    throw e;
                }
                Console.WriteLine("仓库商品数量：" + GoodsStore.GetInstance().GoodsList.Count);
                if (GoodsStore.GetInstance().GoodsList.Count>0)
                {
                    this.ConsumerGoods();
                }
            }
        }
    }
}
