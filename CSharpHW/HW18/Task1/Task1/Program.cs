using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileAccount mobileAccount1 = new MobileAccount(123);
            MobileAccount mobileAccount2 = new MobileAccount(456);
            MobileAccount mobileAccount = new MobileAccount(789);
            MobileOperator mobileOperator = new MobileOperator();
            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);
            mobileOperator.MakeCall(mobileAccount1, mobileAccount);
            mobileOperator.SendMessage(mobileAccount1, mobileAccount2);

        }
    }
}
