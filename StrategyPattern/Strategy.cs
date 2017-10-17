using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
    public class OperationAdd : IStrategy
    {
        #region IStrategy 成员

        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }

        #endregion
    }
    public class OperationSubstract : IStrategy
    {
        #region IStrategy 成员

        public int DoOperation(int num1, int num2)
        {
            return num1 - num2;
        }

        #endregion
    }

    public class OperationMultiply : IStrategy
    {
        #region IStrategy 成员

        public int DoOperation(int num1, int num2)
        {
            return num1*num2;
        }

        #endregion
    }



}
