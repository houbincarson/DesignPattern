using System;

namespace StatePattern
{
    //环境角色---相当于Context类型
    public sealed class Order
    {
        private IOrderState _current;

        public Order()
        {
            _current = new WaitForAcceptance();
            IsCancel = false;
        }

        public double Minute { get; set; }

        public bool IsCancel { get; set; }

        public bool TaskFinished { get; set; }

        public void SetState(IOrderState s)
        {
            _current = s;
        }
        public void Action()
        {
            _current.Process(this);
        }
    }

    //抽象状态角色---相当于State类型
    public interface IOrderState
    {
        //处理订单
        void Process(Order order);
    }

    public sealed class WaitForAcceptance : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("我们开始受理，准备备货！");
            if (order.Minute < 30 && order.IsCancel)
            {
                Console.WriteLine("接受半个小时之内，可以取消订单！");
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
    public sealed class AcceptAndDeliver : IOrderState
    {

        public void Process(Order order)
        {
            Console.WriteLine("我们货物已经准备好，可以发货了，不可以撤销订单！");
            if (order.Minute < 30 && order.IsCancel)
            {
                Console.WriteLine("接受半个小时之内，可以取消订单！");
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
    public sealed class Success : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("订单结算");
            order.SetState(new ConfirmationReceipt());
            order.TaskFinished = true;
            order.Action();
        }
    }
    //确认收货---相当于具体状态角色
    public sealed class ConfirmationReceipt : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("检查货物，没问题可以就可以签收！");
            //order.SetState(null);
            //order.TaskFinished = true;
            //order.Action();
        }
    }
    //取消订单---相当于具体状态角色
    public sealed class CancelOrder : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("检查货物，有问题，取消订单！");
            order.SetState(new CancelOrder());
            order.TaskFinished = true;
            order.Action();
        }
    }

}

