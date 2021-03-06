﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Learning Hard");
            account.Deposit(1000.0);
            account.Deposit(200.0);
            account.Deposit(600.0);

            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(500.00);



            //订单
            Order order = new Order();
            order.Minute = 9;
            order.Action();
            //可以取消订单
            order.IsCancel = true;

            order.Minute = 20;
            order.Action();
            order.Minute = 33;
            order.Action();
            order.Minute = 43;
            order.Action();

            Console.Read();

            Console.ReadKey();
        }
    }
}
