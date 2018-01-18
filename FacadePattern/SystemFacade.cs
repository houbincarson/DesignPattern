using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class SystemFacade
    {
        private AuthoriationSystemA auth;
        private SecuritySystemB security;
        private NetBankSystemC netbank;

        public SystemFacade()
        {
            auth = new AuthoriationSystemA();
            security = new SecuritySystemB();
            netbank = new NetBankSystemC();
        }

        public void Buy()
        {
            auth.MethodA();//身份认证子系统
            security.MethodB();//系统安全子系统
            netbank.MethodC();//网银安全子系统
            Console.WriteLine("我已经成功购买了！");
        }

    }

    

    public class AuthoriationSystemA
    {
        public void MethodA()
        {
            Console.WriteLine("执行身份认证");
        }
    }
    public class SecuritySystemB
    {
        public void MethodB()
        {
            Console.WriteLine("执行系统安全检查");
        }
    }

    public class NetBankSystemC
    {
        public void MethodC()
        {
            Console.WriteLine("执行网银安全检测");
        }
    }
}
