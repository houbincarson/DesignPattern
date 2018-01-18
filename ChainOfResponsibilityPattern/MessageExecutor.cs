using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 消息执行方式
    /// </summary>
    public class MessageExecutor
    {
        public bool Insert(MessageModel model)
        {
            Console.WriteLine("{0},{1}", model.PublishTime,model.Message);
            return true;
        }
    }
}
