using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            //// 创建一个遥控器
            //RemoteControl remoteControl = new ConcreteRemote();

            //// 长虹电视机
            //remoteControl.Implementor = new ChangHong();
            //remoteControl.On();
            //remoteControl.SetChannel();
            //remoteControl.Off();
            //Console.WriteLine();

            //// 三星牌电视机
            //remoteControl.Implementor = new Samsung();
            //remoteControl.On();
            //remoteControl.SetChannel();
            //remoteControl.Off();
            //Console.Read();

            BusinessObject customers = new CustomersBusinessObject("ShangHai");
            customers.Dataacces = new CustomersDataAccess();

            customers.Add("小六");
            Console.WriteLine("增加了一位成员的结果：");
            customers.ShowAll();
            customers.Delete("王五");
            Console.WriteLine("删除了一位成员的结果：");
            customers.ShowAll();
            Console.WriteLine("更新了一位成员的结果：");
            customers.Update("Learning_Hard");
            customers.ShowAll();

            Console.Read();

        }
    }
    #region BLL
    public class BusinessObject
    {
        private DataAccess dataacess;
        private string city;

        public BusinessObject(string city)
        {
            this.city = city;
        }

        public DataAccess Dataacces
        {
            get { return dataacess; }
            set { dataacess = value; }
        }
        // 方法
        public virtual void Add(string name)
        {
            Dataacces.AddRecord(name);
        }
        public virtual void Delete(string name)
        {
            Dataacces.DeleteRecord(name);
        }
        public virtual void Update(string name)
        {
            Dataacces.UpdateRecord(name);
        }
        public virtual string Get(int index)
        {
            return Dataacces.GetRecord(index);
        }
        public virtual void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("{0}的顾客有：", city);
            Dataacces.ShowAllRecords();
        }
    }

    public class CustomersBusinessObject : BusinessObject
    {
        public CustomersBusinessObject(string city) : base(city)
        {

        }
        public override void ShowAll()
        {
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
    #endregion
    #region 相当于三层架构中数据访问层（DAL）
    public abstract class DataAccess
    {
        // 对记录的增删改查操作
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void UpdateRecord(string name);
        public abstract string GetRecord(int index);
        public abstract void ShowAllRecords();
    }
    public class CustomersDataAccess:DataAccess
    {
        private List<string> customers = new List<string>();

        public CustomersDataAccess()
        {
            // 实际业务中从数据库中读取数据再填充列表
            customers.Add("Learning Hard");
            customers.Add("张三");
            customers.Add("李四");
            customers.Add("王五");
        }
        public override void AddRecord(string name)
        {
            customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            customers.Remove(name);
        }

        public override void UpdateRecord(string name)
        {
            customers[0] = name;
        }

        public override string GetRecord(int index)
        {
            return customers[index];
        }

        public override void ShowAllRecords()
        {
            foreach (string name in customers)
            {
                Console.WriteLine(" " + name);
            }
        }
    }
    #endregion
}
