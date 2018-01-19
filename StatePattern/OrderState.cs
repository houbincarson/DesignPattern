using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    //环境角色---相当于Context类型
    public sealed class Order
    {
        private OrderState current;

        public Order()
        {
            current = new WaitForAcceptance();
            IsCancel = false;
        }
        private double minute;
        public double Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public bool IsCancel { get; set; }

        private bool finish;
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }
        public void SetState(OrderState s)
        {
            current = s;
        }
        public void Action()
        {
            current.Process(this);
        }
    }

    //抽象状态角色---相当于State类型
    public interface OrderState
    {
        //处理订单
        void Process(Order order);
    }

    public sealed class WaitForAcceptance : OrderState
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("我们开始受理，准备备货！");
            if (order.Minute < 30 && order.IsCancel)
            {
                System.Console.WriteLine("接受半个小时之内，可以取消订单！");
                order.SetState(new CancelOrder());
                order.TaskFinished = true;
                order.Action();
            }
            order.SetState(new AcceptAndDeliver());
            order.TaskFinished = false;
            order.Action();
        }
    }
     //受理发货---相当于具体状态角色
    public sealed class AcceptAndDeliver : OrderState
    {

        public void Process(Order order)
        {
            System.Console.WriteLine("我们货物已经准备好，可以发货了，不可以撤销订单！");
            if (order.Minute < 30 && order.IsCancel)
            {
                System.Console.WriteLine("接受半个小时之内，可以取消订单！");
                order.SetState(new CancelOrder());
                order.TaskFinished = true;
                order.Action();
            }
            if (order.TaskFinished == false)
            {
                order.SetState(new Success());
                order.Action();
            }
        }
    }
    public sealed class Success : OrderState
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("订单结算");
            order.SetState(new ConfirmationReceipt());
            order.TaskFinished = true;
            order.Action();
        }
    }
    //确认收货---相当于具体状态角色
    public sealed class ConfirmationReceipt : OrderState
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("检查货物，没问题可以就可以签收！");
            //order.SetState(null);
            //order.TaskFinished = true;
            //order.Action();
        }
    }
    //取消订单---相当于具体状态角色
    public sealed class CancelOrder : OrderState
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("检查货物，有问题，取消订单！");
            order.SetState(new CancelOrder());
            order.TaskFinished = true;
            order.Action();
        }
    }

}

