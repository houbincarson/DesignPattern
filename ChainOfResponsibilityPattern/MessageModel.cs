using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 消息模型
    /// </summary>
    public class MessageModel
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 消息发布时间
        /// </summary>
        public DateTime PublishTime { get; set; }

        public MessageModel(string msg, DateTime pt)
        {
            Message = msg;
            PublishTime = pt;
        }
    }
}
