using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProducerConsumerModel
{
    public class Goods
    {
        public string GoodsName { set; get; }

        public Goods(string goodsname)
        {
            GoodsName = goodsname; 
        }
    }

    public class GoodsStore
    {
        public List<Goods> GoodsList = new List<Goods>();
        private static readonly GoodsStore goodsStore = new GoodsStore();

        GoodsStore()
        {

        }

        public static GoodsStore GetInstance()
        {
            return goodsStore;
        }
    }
}
