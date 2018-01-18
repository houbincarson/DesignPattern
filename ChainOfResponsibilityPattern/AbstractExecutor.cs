using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 抽象执行者
    /// </summary>
    public  abstract class AbstractExecutor
    {
        protected AbstractExecutor Executor;
        /// <summary>
        /// 设置上一级执行者
        /// </summary>
        /// <param name="executor"></param>
        public void SetUpSuccessor(AbstractExecutor executor)
        {
            this.Executor = executor;
        }
        /// <summary>
        /// 执行方法
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        public abstract string Insert(MessageModel mm);
    }

    public class Employee : AbstractExecutor
    {
        public override string Insert(MessageModel mm)
        {
            string rtn = "";
            // 插入的信息字符数小于5
            if (mm.Message.Length < 5)
            {
                MessageExecutor me = new MessageExecutor();
                if (me.Insert(mm))
                {
                    rtn = "执行者：雇员" + " 内容：" + mm.Message + " 时间：" + mm.PublishTime.ToString();
                }
            }
            // 否则让上级去执行
            else if (base.Executor != null)
            {
                rtn = Executor.Insert(mm);
            }

            return rtn;
        }
    }
    public class Leader : AbstractExecutor
    {
        public override string Insert(MessageModel mm)
        {
            string rtn = "";
            // 插入的信息字符数小于5
            if (mm.Message.Length < 10)
            {
                MessageExecutor me = new MessageExecutor();
                if (me.Insert(mm))
                {
                    rtn = "执行者：主管" + " 内容：" + mm.Message + " 时间：" + mm.PublishTime.ToString();
                }
            }
            // 否则让上级去执行
            else if (base.Executor != null)
            {
                rtn = Executor.Insert(mm);
            }

            return rtn;
        }
    }
    public class Manager : AbstractExecutor
    {
        public override string Insert(MessageModel mm)
        {
            string rtn = "";
            // 插入的信息字符数小于5
            if (mm.Message.Length < 15)
            {
                MessageExecutor me = new MessageExecutor();
                if (me.Insert(mm))
                {
                    rtn = "执行者：经理" + " 内容：" + mm.Message + " 时间：" + mm.PublishTime.ToString();
                }
            }
            // 否则让上级去执行
            else
            {
                rtn = "你所插入的Message不符合要求";
            }

            return rtn;
        }
    }



}
