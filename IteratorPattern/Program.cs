﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int) iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }
            Console.ReadLine();
        }
    }
}
